using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kontr
{
    public partial class MainPage : ContentPage
    {
        TimePicker tpicker;
        Label lbl;
        Image img;
        Entry entry;
        string hh;
        public MainPage()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
        };
            tpicker = new TimePicker()
            {
                Time = new TimeSpan(0, 0, 0)
            };
            tpicker.PropertyChanged += Tpicker_PropertyChanged;
            gr.Children.Add(tpicker, 2, 1);
            lbl = new Label()
            {
                Text = "Я ложусь спать",
                TextColor = Color.Green,
                FontSize = 20
            };
            gr.Children.Add(lbl, 1, 0);
            img = new Image { Source = "nol.jpg" };
            gr.Children.Add(img, 0, 1);
            Content = gr;
        }

        private void Tpicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var time = tpicker.Time.Hours;
            if (time == 1)
            {
                lbl.Text = "Засыпаю";
                img.Source = "odin.jpg";
            }
            else if (time == 2)
            {
                lbl.Text = "Уже почти заснул";
                img.Source = "dva.jpg";
            }
            else if (time == 3)
            {
                lbl.Text = "Уже сплю";
                img.Source = "tri.jpg";
            }
            else if (time == 4)
            {
                lbl.Text = "Долго сплю";
                img.Source = "chetyre.jpg";
            }
            else if (time == 5)
            {
                lbl.Text = "Все еще сплю";
                img.Source = "pyat.jpg";
            }
            else if (time == 6)
            {
                lbl.Text = "До сих пор сплю";
                img.Source = "shest.jpg";
            }
            else if (time == 7)
            {
                lbl.Text = "Просыпаюсь и встаю";
                img.Source = "sem.jpg";
            }
            else if (time == 8)
            {
                lbl.Text = "Кушаю и готовлюсь идти в тех";
                img.Source = "vosem.jpg";
            }
            else if (time == 9)
            {
                lbl.Text = "Сижу на уроках";
                img.Source = "devyat.jpg";
            }
            else if (time == 10)
            {
                lbl.Text = "Все еще сижу на уроках";
                img.Source = "desyat.jpg";
            }
            else if (time == 11)
            {
                lbl.Text = "Обедаю в техе";
                img.Source = "odinatsat.jpg";
            }
            else if (time == 12)
            {
                lbl.Text = "Снова сижу на уроках";
                img.Source = "dvenatsat.jpg";
            }
            else if (time == 13)
            {
                lbl.Text = "Еду домой с учебы";
                img.Source = "trinatsat.jpg";
            }
            else if (time == 14)
            {
                lbl.Text = "Кушаю дома";
                img.Source = "chetirnatsat.jpg";
            }
            else if (time == 15)
            {
                lbl.Text = "Ложусь отдыхать";
                img.Source = "petnatsat.jpg";
            }
            else if (time == 16)
            {
                lbl.Text = "Все еще отдыхаю";
                img.Source = "shestnatsat.jpg";
            }
            else if (time == 17)
            {
                lbl.Text = "Иду гулять";
                img.Source = "semnatsat.jpg";
            }
            else if (time == 18)
            {
                lbl.Text = "Гуляю";
                img.Source = "vosemnatsat.jpg";
            }
            else if (time == 19)
            {
                lbl.Text = "Прихожу домой";
                img.Source = "devjatnatsat.jpg";
            }
            else if (time == 20)
            {
                lbl.Text = "Ужинаю";
                img.Source = "dvatsat.jpg";
            }
            else if (time == 21)
            {
                lbl.Text = "Иду в душ";
                img.Source = "dvatsatodin.jpg";
            }
            else if (time == 22)
            {
                lbl.Text = "Играю в комп";
                img.Source = "dvatsatdva.jpg";
            }
            else if (time == 23)
            {
                lbl.Text = "Общаюсь в дискорде";
                img.Source = "dvatsattri.jpg";
            }
        }
    }
}
