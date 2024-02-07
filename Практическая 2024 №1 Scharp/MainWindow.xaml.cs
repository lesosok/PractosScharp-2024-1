using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_2024__1_Scharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height = 500;
            this.Width = 815;
        }
        int player = 1;
        int allmoves = 0;

        private void AllButtons_Click(object sender, RoutedEventArgs e)
        {
            allmoves++;
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "x");
                    player = 2;
                    break;
                case 2:
                    sender.GetType().GetProperty("Content").SetValue(sender, "o");
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            Winner();
        }

        private void Winner()
        {
            if (A1.Content == A2.Content && A2.Content == A3.Content)
            {
                if (A1.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (B1.Content == B2.Content && B2.Content == B3.Content)
            {
                if (B1.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (C1.Content == C2.Content && C2.Content == C3.Content)
            {
                if (C1.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (A1.Content == B1.Content && B1.Content == C1.Content)
            {
                if (A1.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (A2.Content == B2.Content && B2.Content == C2.Content)
            {
                if (A2.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (A3.Content == B3.Content && B3.Content == C3.Content)
            {
                if (A3.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (A1.Content == B2.Content && B2.Content == C3.Content)
            {
                if (A1.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            if (A3.Content == B2.Content && B2.Content == C1.Content)
            {
                if (A3.Content != "")
                {
                    switch (player)
                    {
                        case 1:
                            Shower.Text = "Победили нолики!";
                            break;
                        case 2:
                            Shower.Text = "Победили крестики!";
                            break;
                    }
                    Disabler();
                }
            }
            else if (allmoves == 9)
            {
                Shower.Text = "Ничья!";
            }
        }

        private void Disabler()
        {
            A1.IsEnabled = false;
            A2.IsEnabled = false;
            A3.IsEnabled = false;

            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;

            C1.IsEnabled = false;
            C2.IsEnabled = false;
            C3.IsEnabled = false;
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            A1.Content = "";
            A1.IsEnabled = true;
            A2.Content = "";
            A2.IsEnabled = true;
            A3.Content = "";
            A3.IsEnabled = true;

            B1.Content = "";
            B1.IsEnabled = true;
            B2.Content = "";
            B2.IsEnabled = true;
            B3.Content = "";
            B3.IsEnabled = true;

            C1.Content = "";
            C1.IsEnabled = true;
            C2.Content = "";
            C2.IsEnabled = true;
            C3.Content = "";
            C3.IsEnabled = true;

            Shower.Text = "Крестики-нолики";
            allmoves = 0;
            if (player == 1)
            {
                player = 1;
            }
            else
            {
                player = 2;
            }
        }
    }
}
