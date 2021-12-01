using System.ComponentModel;

using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace XamarinFormsColorPicker
{
    public class MainPageVM : BaseVM
    {
        Color color;
        string name;

        public double Hue
        {
            set
            {
                if (color.Hue != value)
                {
                    Color = Color.FromHsla(value, color.Saturation, color.Luminosity);
                }
            }
            get
            {
                return color.Hue;
            }
        }

        public double Saturation
        {
            set
            {
                if (color.Saturation != value)
                {
                    Color = Color.FromHsla(color.Hue, value, color.Luminosity);
                }
            }
            get
            {
                return color.Saturation;
            }
        }

        public double Luminosity
        {
            set
            {
                if (color.Luminosity != value)
                {
                    Color = Color.FromHsla(color.Hue, color.Saturation, value);
                }
            }
            get
            {
                return color.Luminosity;
            }
        }

        public Color Color
        {
            set
            {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged(nameof(Hue));
                    OnPropertyChanged(nameof(Saturation));
                    OnPropertyChanged(nameof(Luminosity));
                    OnPropertyChanged(nameof(Color));

                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hue"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Saturation"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Luminosity"));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Color"));

                    Name = NamedColor.GetNearestColorName(color);
                }
            }
            get
            {
                return color;
            }
        }

        public string Name
        {
            private set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get
            {
                return name;
            }
        }
    }
}