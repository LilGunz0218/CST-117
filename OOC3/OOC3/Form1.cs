using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOC3
{
    public partial class Form1 : Form
    {
        public static System.IO.StreamWriter sw;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Tommy Trujillo III
             * This is my own work.
             * */
            sw = System.IO.File.CreateText("OUPAT.txt");
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                string allText = sr.ReadToEnd();
                this.richTextBox1.Text = allText;

                string[] words = allText.Split();

               
               
                for (int i = 0; i < words.Length; i++)
                {
                    this.richTextBox1.Text += words[i].ToLower(); //puts words in lowercase
                }

                string longestWord = "";
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == 0) //finds longest word 
                    {
                        longestWord = words[i];
                    }
                    else if (longestWord.Length < words[i].Length)
                    {
                        longestWord = words[i];
                    }
                    
                }
                this.richTextBox1.Text += "\n" + "The Longest word is: " + longestWord;


                string alphafirst = "";
                string alphalast = "";
                for (int i = 0; i < words.Length; i++) //Finds the first and last letter, alphabetically
                {
                    if (i == 0)
                    {
                        alphafirst = words[i];
                        alphalast = words[i];
                    }

                    if (alphafirst.CompareTo(words[i]) > 0 && words[i].Length>0)
                    {
                        alphafirst = words[i];

                    }
                    else if (alphalast.CompareTo(words[i]) < 0)
                    {
                        alphalast = words[i];
                    }
                }
                    this.richTextBox1.Text += "\n" + "The First word is: " + alphafirst + "\n" + "The Last word is: " + alphalast;

                int count = 0;
                int countmax = 0;
                string maxvowel = "";

                for (int i = 0; i < words.Length; i++)
                {
                    String currWord = words[i];

                    for (int j = 0; j < currWord.Length; j++)
                    {
                        if (currWord[j] == 'a' || currWord[j] == 'e' || currWord[j] == 'i' || 
                            currWord[j] == 'o' || currWord[j] == 'u')
                        {
                            count++;
                        }
                    }
                    if (count > countmax)
                    {
                        countmax = count;
                        maxvowel = currWord;
                    }
                    count = 0;
                }
                richTextBox1.Text += "\n" + "The word with the most vowels is: " + maxvowel;
                sw.Close();

                }
            }
           
        }  
    }

