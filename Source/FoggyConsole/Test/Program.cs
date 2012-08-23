﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FoggyConsole;
using FoggyConsole.Controls;

namespace FoggyConsole.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Panel rootPanel = new Panel();
            rootPanel.Top = 3;
            rootPanel.Left = 3;
            rootPanel.Width = 70;
            rootPanel.Height = 17;
            rootPanel.Name = "rootPanel";

            Button button0 = new Button("asd0") { Left = 1, Top = 1, Name = "asd0" };
            Button button1 = new Button("asd1") { Left = 10, Top = 1, Name = "asd1" };
            Button button2 = new Button("asd2") { Left = 15, Top = 2, Name = "asd2" };
            
            rootPanel.Add(button0);
            rootPanel.Add(button1);
            rootPanel.Add(button2);



            Panel innerPanel1 = new Panel();
            innerPanel1.Top = 5;
            innerPanel1.Left = 5;
            innerPanel1.Width = 20;
            innerPanel1.Height = 20;
            innerPanel1.Name = "innerPanel1";

            Button button3 = new Button("asd3") { Left = 2, Top = 2, Name = "asd3" };
            innerPanel1.Add(button3);



            Panel innerPanel2 = new Panel();
            innerPanel2.Top = 4;
            innerPanel2.Left = 28;
            innerPanel2.Width = 45;
            innerPanel2.Height = 12;
            innerPanel2.Name = "innerPanel2";

            Button button4 = new Button("asd4") { Left = 2, Top = 2, Name = "asd4" };
            Button button5 = new Button("asd5") { Left = 4, Top = 3, Name = "asd5" };
            innerPanel2.Add(button4);
            innerPanel2.Add(button5);


            Panel innerPanel3 = new Panel();
            innerPanel3.Top = 5;
            innerPanel3.Left = 5;
            innerPanel3.Height = 5;
            innerPanel3.Width = 20;
            innerPanel3.Name = "innerInnerPanel3";
            Button b = new Button("asd6") { Left = 2, Top = 2, Name = "asd6" };
            innerPanel3.Add(b);
            innerPanel2.Add(innerPanel3);

            Panel innerPanel4 = new Panel();
            innerPanel4.Top = 5;
            innerPanel4.Left = 25;
            innerPanel4.Height = 50;
            innerPanel4.Width = 40;
            innerPanel4.Name = "innerInnerPanel4";
            Button b2 = new Button("asd6") { Left = 2, Top = 2, Name = "asd6" };
            innerPanel4.Add(b2);
            innerPanel2.Add(innerPanel4);
            

            rootPanel.Add(innerPanel1);
            rootPanel.Add(innerPanel2);

            Application app = new Application(rootPanel);
            app.FocusManager = new FocusManager(button0);
            app.Run();
        }
    }
}