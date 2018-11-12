using System.IO;
using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFileManager {
    class TextEditorController {
        private string _path;
        private string _name;
        private string _curTextBox = "";

        public void LoadFile(string newPath, RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            if (newPath == "") {
                _name = "";
                richTextBox1.Text = "";
                currentFileName.Text = "";
            } else {
                StreamReader name = new StreamReader(newPath, Encoding.UTF8);
                richTextBox1.Text = name.ReadToEnd();
                name.Close();

                FileInfo fi = new FileInfo(newPath);
                _name = fi.Name;
                currentFileName.Text = _name;
            }
            _path = newPath;
            _curTextBox = richTextBox1.Text;
        }

        public bool SaveFile(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            if (_path == "") {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt|Html Files (*.html)|*.html";
                sfd.Title = "Сохранить";
                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "") {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();
                    currentFileName.Text = sfd.FileName;
                } else {
                    return false;
                }
            } else {
                StreamWriter write_text = new StreamWriter(_path, false, Encoding.GetEncoding(1251)); //Класс для перезаписи в файл
                write_text.WriteLine(richTextBox1.Text); //Записываем в файл текст из текстового поля
                write_text.Close(); //Закрываем файл
            }
            _curTextBox = richTextBox1.Text;
            return true;
        }

        public bool SaveFileAs(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|Html Files (*.html)|*.html";
            sfd.Title = "Сохранить";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "") {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(richTextBox1.Text);
                sw.Close();
                currentFileName.Text = sfd.FileName;
            } else {
                return false;
            }
            _curTextBox = richTextBox1.Text;
            return true;
        }

        public bool Close(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            if (richTextBox1.Text != _curTextBox) {
                DialogResult res = MessageBox.Show("Сохранить изменения в файле " + _name + "?", "Вы уверены?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) {
                    SaveFile(richTextBox1, currentFileName);
                } else if (res == DialogResult.Cancel) {
                    return false;
                }
            }
            return true;
        }

        public void OpenFile(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|Html Files (*.html)|*.html";
            ofd.Title = "Открыть";

            if (ofd.ShowDialog() == DialogResult.OK) {
                LoadFile(ofd.FileName, richTextBox1, currentFileName);
            }
        }

        public void NewFile(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            if (Close(richTextBox1, currentFileName)) {
                LoadFile("", richTextBox1, currentFileName);
            }
        }

        public void CheckTextBox(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            if (_path != "" && currentFileName.Text[currentFileName.Text.Length - 1] != '*') {
                if (richTextBox1.Text != _curTextBox) {
                    currentFileName.Text += "*";
                } else {
                    currentFileName.Text.Remove(currentFileName.Text.Length - 1, 1);
                }
            }
        }


        public void InverseRegister(RichTextBox richTextBox1) {
            string text;
            if (richTextBox1.SelectedText == "") {
                text = richTextBox1.Text;
            } else {
                text = richTextBox1.SelectedText;
            }

            string reversedText = new string(
                text.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());

            if (richTextBox1.SelectedText == "") {
                richTextBox1.Text = reversedText;
            } else {
                richTextBox1.SelectedText = reversedText;
            }
        }

        public void MergeHTML(RichTextBox richTextBox1, ToolStripMenuItem currentFileName) {
            string input1 = richTextBox1.Text;
            string input2 = "";
            string body1 = "<body>";
            string body2 = "</body>";
            string style1 = "<style>";
            string style2 = "</style>";
            const int p = 53;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Html Files (*.html)|*.html";
            ofd.Title = "Merge with..";

            if (ofd.ShowDialog() == DialogResult.OK) {
                StreamReader name = new StreamReader(ofd.FileName);
                input2 = name.ReadToEnd();
                name.Close();
            }

            //степени p
            List<ulong> p_pow1 = new List<ulong>(input1.Length);
            p_pow1.Add(1);
            for (int i = 1; i < p_pow1.Capacity; ++i)
                p_pow1.Add(p_pow1[i - 1] * p);


            List<ulong> p_pow2 = new List<ulong>(input2.Length);
            p_pow2.Add(1);
            for (int i = 1; i < p_pow2.Capacity; ++i)
                p_pow2.Add(p_pow2[i - 1] * p);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //хэши style1 и style2
            ulong h_style1 = 0;
            for (int i = 0; i < style1.Length; ++i)
                h_style1 += (ulong)(style1[i] - 'a' + 1) * p_pow1[i];

            ulong h_style2 = 0;
            for (int i = 0; i < style2.Length; ++i)
                h_style2 += (ulong)(style2[i] - 'a' + 1) * p_pow1[i];

            //хэши body1 и body2
            ulong h_body1 = 0;
            for (int i = 0; i < body1.Length; ++i)
                h_body1 += (ulong)(body1[i] - 'a' + 1) * p_pow1[i];

            ulong h_body2 = 0;
            for (int i = 0; i < body2.Length; ++i)
                h_body2 += (ulong)(body2[i] - 'a' + 1) * p_pow1[i];

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //хэши от всех префиксов строки input1
            List<ulong> h_input1 = new List<ulong>(input1.Length);

            for (int i = 0; i < input1.Length; ++i) {
                h_input1.Add((ulong)(input1[i] - 'a' + 1) * p_pow1[i]);
                if (i != 0)
                    h_input1[i] += h_input1[i - 1];
            }

            //хэши от всех префиксов строки input2
            List<ulong> h_input2 = new List<ulong>(input2.Length);

            for (int i = 0; i < input2.Length; ++i) {
                h_input2.Add((ulong)(input2[i] - 'a' + 1) * p_pow2[i]);
                if (i != 0)
                    h_input2[i] += h_input2[i - 1];
            }

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            int i1, i2, j1, j2;

            //перебираем все подстроки input1 длины |style1| и сравниваем их
            for (i1 = 0; i1 + style1.Length - 1 < input1.Length; ++i1) {
                ulong cur_h = h_input1[i1 + style1.Length - 1];
                if (i1 != 0) {
                    cur_h -= h_input1[i1 - 1];
                }
                if (cur_h == h_style1 * p_pow1[i1]) {
                    break;
                }
            }
            //перебираем все подстроки input1 длины |style2| и сравниваем их
            for (i2 = 0; i2 + style2.Length - 1 < input1.Length; ++i2) {
                ulong cur_h = h_input1[i2 + style2.Length - 1];
                if (i2 != 0) {
                    cur_h -= h_input1[i2 - 1];
                }
                if (cur_h == h_style2 * p_pow1[i2]) {
                    break;
                }
            }

            //перебираем все подстроки input1 длины |body1| и сравниваем их
            for (j1 = 0; j1 + body1.Length - 1 < input1.Length; ++j1) {
                ulong cur_h = h_input1[j1 + body1.Length - 1];
                if (j1 != 0) {
                    cur_h -= h_input1[j1 - 1];
                }
                if (cur_h == h_body1 * p_pow1[j1]) {
                    break;
                }
            }
            //перебираем все подстроки input1 длины |body2| и сравниваем их
            for (j2 = 0; j2 + body2.Length - 1 < input1.Length; ++j2) {
                ulong cur_h = h_input1[j2 + body2.Length - 1];
                if (j2 != 0) {
                    cur_h -= h_input1[j2 - 1];
                }
                if (cur_h == h_body2 * p_pow1[j2]) {
                    break;
                }
            }

            i1 += 7;
            j1 += 6;
            string style_input1 = input1.Substring(i1, i2 - i1);
            string body_input1 = input1.Substring(j1, j2 - j1);
            //MessageBox.Show(style_input1);
            //MessageBox.Show(body_input1);


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //перебираем все подстроки input2 длины |style1| и сравниваем их
            for (i1 = 0; i1 + style1.Length - 1 < input2.Length; ++i1) {
                ulong cur_h = h_input2[i1 + style1.Length - 1];
                if (i1 != 0) {
                    cur_h -= h_input2[i1 - 1];
                }
                if (cur_h == h_style1 * p_pow1[i1]) {
                    break;
                }
            }
            //перебираем все подстроки input2 длины |style2| и сравниваем их
            for (i2 = 0; i2 + style2.Length - 1 < input2.Length; ++i2) {
                ulong cur_h = h_input2[i2 + style2.Length - 1];
                if (i2 != 0) {
                    cur_h -= h_input2[i2 - 1];
                }
                if (cur_h == h_style2 * p_pow2[i2]) {
                    break;
                }
            }
            //перебираем все подстроки input2 длины |body1| и сравниваем их
            for (j1 = 0; j1 + body1.Length - 1 < input2.Length; ++j1) {
                ulong cur_h = h_input2[j1 + body1.Length - 1];
                if (j1 != 0) {
                    cur_h -= h_input2[j1 - 1];
                }
                if (cur_h == h_body1 * p_pow1[j1]) {
                    break;
                }
            }
            //перебираем все подстроки input2 длины |body2| и сравниваем их
            for (j2 = 0; j2 + body2.Length - 1 < input2.Length; ++j2) {
                ulong cur_h = h_input2[j2 + body2.Length - 1];
                if (j2 != 0) {
                    cur_h -= h_input2[j2 - 1];
                }
                if (cur_h == h_body2 * p_pow1[j2]) {
                    break;
                }
            }

            i1 += 7;
            j1 += 6;
            string style_input2 = input2.Substring(i1, i2 - i1);
            string body_input2 = input2.Substring(j1, j2 - j1);
            //MessageBox.Show(style_input2);
            //MessageBox.Show(body_input2);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            string beforeStyle_input2 = input2.Substring(0, i1);
            string Style_Body_input2 = input2.Substring(i2, j1 - i2);
            string afterBody_input2 = input2.Substring(j2, input2.Length - 1 - j2);

            //MessageBox.Show(beforeStyle_input2);
            //MessageBox.Show(Style_Body_input2);
            //MessageBox.Show(afterBody_input2);

            LoadFile("", richTextBox1, currentFileName);
            richTextBox1.Text = beforeStyle_input2 + style_input1 + Style_Body_input2 + body_input1 + body_input2 + afterBody_input2;
        }

        public void CorrectMistakes(RichTextBox richTextBox1) {
            string[] dictionary;
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt Files (*.txt)|*.txt";
            ofd.Title = "Select a dictionary";

            if (ofd.ShowDialog() == DialogResult.OK) {
                dictionary = System.IO.File.ReadAllLines(ofd.FileName);
            }
            */
            dictionary = System.IO.File.ReadAllLines("F:\\Den\\Coding Projects\\WindowsFileManager\\WindowsFileManager\\Dictionary.txt");

            string newText = "";
            string word = "";
            string newWord = "";
            List<string> wordTypes = new List<string>();
            List<string> wordTypes2 = new List<string>();
            richTextBox1.Text += " ";

            foreach (char ch in richTextBox1.Text) {
                if (Char.IsLetter(ch)) {
                    word += ch;
                } else {
                    //получили слово
                    if (word.Length < 2) {
                        word = "";
                        continue;
                    }

                    //слово уже в словаре----------------------------------------------------------
                    foreach (string word_dict in dictionary) {
                        if (word_dict == word) {
                            newText += word + " ";
                            word = "";
                            break;
                        }
                    }

                    if (word == "") {
                        continue;
                    }

                    //слова нет в словаре----------------------------------------------------------

                    //переставления букв
                    for (int i = 0; i < word.Length - 1; ++i) {
                        newWord = word;
                        char temp = newWord[i + 1];
                        newWord = newWord.Insert(i + 2, newWord[i].ToString());
                        newWord = newWord.Remove(i, 1);
                        wordTypes.Add(newWord);
                    }

                    //убираем повторения букв
                    newWord = word;
                    for (int i = 0; i < newWord.Length - 1; ++i) {
                        if (newWord[i + 1] == newWord[i])
                            newWord = newWord.Remove(i + 1, 1);
                    }
                    wordTypes.Add(newWord);

                    //убираем лишние буквы
                    for (int i = 0; i < word.Length; ++i) {
                        //newWord = word;
                        newWord = word.Remove(i, 1);
                        wordTypes.Add(newWord);
                    }

                    /*
                    foreach (string s in wordTypes) {
                        MessageBox.Show(s);
                    }
                    */
                    wordTypes.Add(word.ToLower());



                    bool _off = false;

                    foreach (string wordType in wordTypes) {
                        foreach (string word_dict in dictionary) {
                            if (word_dict == wordType || CompareWords(word, word_dict) == word_dict.Length - 1) {
                                DialogResult correct = MessageBox.Show("Заменить слово <" + word + "> на слово <" + word_dict + ">?", "Исправить ошибку?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (correct == DialogResult.Yes) {
                                    newText += word_dict + " ";
                                    _off = true;
                                    break;
                                } else {
                                    newText += wordType + " ";
                                }
                            }
                        }
                        if (_off)
                            break;
                    }

                    word = "";
                    wordTypes.Clear();
                    wordTypes2.Clear();
                }

            }


            newText = newText.Remove(newText.Length - 1, 1);
            richTextBox1.Text = newText;
        }

        public static int CompareWords(string word1, string word2) {
            char[] wordChar1 = word1.ToCharArray();
            char[] wordChar2 = word2.ToCharArray();
            int value = 0;

            if (wordChar1.Length != wordChar2.Length)
                return 0;

            for (int i = 0; i < wordChar1.Length; ++i) {
                if (wordChar1[i] == wordChar2[i])
                    ++value;
            }

            return value;
        }
    }
}
