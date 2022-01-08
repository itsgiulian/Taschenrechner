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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        }

        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            tb_erste.Text = variable1.Replace(".", ",");
            double wert1;
            string variable2 = tb_zweite.Text;
            tb_zweite.Text = variable2.Replace(".", ",");
            double wert2;

            if (double.TryParse(variable1, out wert1) && double.TryParse(variable2, out wert2))     //Prüfen, ob Erste Eingabe und Zweite Eingabe eine Zahl sind
            {



                Double erste = Convert.ToDouble(tb_erste.Text);                                     //CONV IN EINE ZAHL DEKLARQATION

                Double zweite = Convert.ToDouble(tb_zweite.Text);                                   //Zahl im Double Konvertieren

                Double ergebnis_plus = erste + zweite;                                              //Das ergebnis ist die addition der ersten und zweiten Zahl

                Double ergebnis_plus_gerundet = Math.Round(ergebnis_plus, 3);                       //Das gerundete Ergebnis ist auf 3 NK-Stellen gerundet


                string ausgabe = Convert.ToString(ergebnis_plus_gerundet);                          //Das gerundete Ergebnis wird in einen string Konvertiert

                tb_fertig.Text = (ausgabe);                                                         //Im string wird das Ergebnis dann ausgegeben in der Textbox  
            }

            else
            {
                MessageBox.Show("EY DU! Das ist keine Zahl WTF! Bist du dumm oder so?!\r\nBitte gebe eine Zahl ein!");  //Trifft die Bedingung, dass BEIDE Eingaben eine Zahl sind, nicht zu, dann wird der Text in einer MessageBox aufgeploppt
                return;     //Durch return stürzt das Programm nicht gleich ab, sondern man hat die Chance erneut Eingaben zu betätigen.
            }
        }




        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            tb_erste.Text = variable1.Replace(".", ",");
            double wert1;
            string variable2 = tb_zweite.Text;
            tb_zweite.Text = variable2.Replace(".", ",");
            double wert2;

            if (double.TryParse(variable1, out wert1) && double.TryParse(variable2, out wert2))
            {
                Double erste = Convert.ToDouble(tb_erste.Text);

                Double zweite = Convert.ToDouble(tb_zweite.Text);

                Double ergebnis_minus = erste - zweite;

                Double ergebnis_minus_gerundet = Math.Round(ergebnis_minus, 3);

                string ausgabe = Convert.ToString(ergebnis_minus_gerundet);
                tb_fertig.Text = (ausgabe);
            }

            else
            {
                MessageBox.Show("EY DU! Das ist keine Zahl WTF! Bist du dumm oder so?!\r\nBitte gebe eine Zahl ein!");
                return;
            }
        }





        private void btn_geteilt_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            double wert1;
            tb_erste.Text = variable1.Replace(".", ",");
            string variable2 = tb_zweite.Text;
            double wert2;
            tb_zweite.Text = variable2.Replace(".", ",");

            if (double.TryParse(variable1, out wert1) && double.TryParse(variable2, out wert2))
            {
                Double erste = Convert.ToDouble(tb_erste.Text);

                Double zweite = Convert.ToDouble(tb_zweite.Text);

                Double ergebnis_geteilt = erste / zweite;

                Double ergebnis_geteilt_gerundet = Math.Round(ergebnis_geteilt, 3);

                string ausgabe = Convert.ToString(ergebnis_geteilt_gerundet);
                tb_fertig.Text = (ausgabe);
            }

            else
            {
                MessageBox.Show("EY DU! Das ist keine Zahl WTF! Bist du dumm oder so?!\r\nBitte gebe eine Zahl ein!");
                return;
            }
        }




        private void btn_mal_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            double wert1;
            tb_erste.Text = variable1.Replace(".", ",");
            string variable2 = tb_zweite.Text;
            double wert2;
            tb_zweite.Text = variable2.Replace(".", ",");

            if (double.TryParse(variable1, out wert1) && double.TryParse(variable2, out wert2))
            {
                Double erste = Convert.ToDouble(tb_erste.Text);

                Double zweite = Convert.ToDouble(tb_zweite.Text);

                Double ergebnis_mal = erste * zweite;

                Double ergebnis_mal_gerundet = Math.Round(ergebnis_mal, 3);

                string ausgabe = Convert.ToString(ergebnis_mal_gerundet);
                tb_fertig.Text = (ausgabe);
            }


            else
            {
                MessageBox.Show("EY DU! Das ist keine Zahl WTF! Bist du dumm oder so?!\r\nBitte gebe eine Zahl ein!");
                return;
            }
        }

        private void btn_wurzel_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            double wert1;
            tb_erste.Text = variable1.Replace(".", ",");
            string variable2 = tb_zweite.Text;


            if (double.TryParse(variable1, out wert1) && wert1 > 0 && variable2 == string.Empty)     //Bedingung: Erste Eingabe muss eine Zahl>0 sein und die zweite Spalte muss leer sein
            {
                Double erste = Convert.ToDouble(tb_erste.Text);
                Double sqrt = Math.Sqrt(erste);

                Double ergebnis_wurzel_gerundet = Math.Round(sqrt, 3);

                string ausgabe = Convert.ToString(ergebnis_wurzel_gerundet);
                tb_fertig.Text = (ausgabe);
            }


            else
            {
                MessageBox.Show("Fehler! Du hast... \r\n ... keine Zahl in die Erste Spalte geschrieben! \r\n ... etwas in die Zweite Spalte geschrieben! \r\n ... keine positive Zahl in die Erste Spalte geschrieben! \r\n Bitte gebe nur in die Erste Spalte eine Zahl ein, die größer als 0 ist!");
                return;
            }


        }

        private void btn_hoch2_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            double wert1;
            tb_erste.Text = variable1.Replace(".", ",");
            string variable2 = tb_zweite.Text;


            if (double.TryParse(variable1, out wert1) && variable2 == string.Empty)
            {
                Double erste = Convert.ToDouble(tb_erste.Text);
                Double ergebnis_hoch2 = erste * erste;

                Double ergebnis_hoch2_gerundet = Math.Round(ergebnis_hoch2, 3);

                string ausgabe = Convert.ToString(ergebnis_hoch2_gerundet);
                tb_fertig.Text = (ausgabe);
            }


            else
            {
                MessageBox.Show("Entweder hast du keine Zahl oder auch in die 2te Spalte etwas reingeschrieben...\r\nBitte schreibe nur in die erste Spalte eine Zahl rein!");
                return;
            }
        }

        private void btn_hochn_Click(object sender, RoutedEventArgs e)
        {
            string variable1 = tb_erste.Text;
            double wert1;
            tb_erste.Text = variable1.Replace(".", ",");
            string variable2 = tb_zweite.Text;
            double wert2;
            tb_zweite.Text = variable2.Replace(".", ",");

            if (double.TryParse(variable1, out wert1) && double.TryParse(variable2, out wert2))
            {
                Double erste = Convert.ToDouble(tb_erste.Text);
                Double zweite = Convert.ToDouble(tb_zweite.Text);

                double var = Math.Pow(erste, zweite);

                Double ergebnis_hochn_gerundet = Math.Round(var, 3);

                string ausgabe = Convert.ToString(ergebnis_hochn_gerundet);
                tb_fertig.Text = (ausgabe);
            }


            else
            {
                MessageBox.Show("Fehler! Erste Spalte: Basiszahl, Zweite Spalte: Hochzahl");
                return;
            }
        }

        private void btn_help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Deine Ergebnisse werden auf 3 Nachkommastellen gerundet. \r\n +/-/÷/×: In jede Spalte eine Zahl eintragen. \r\n √: In die Erste Spalte eine Zahl eintragen.\r\n^2: In die Erste Spalte eine Zahl eintragen.\r\n^n: Erste Spalte: Basiszahl, Zweite Spalte: Hochzahl");
        }
    }

}