using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.View.LayoutTag;

public partial class ScrollView : ContentPage
{
    
    public class Row : INotifyPropertyChanged
    {
        private string name;
        private string description;
        private string imagePath;
        
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public string ImagePath
        {
            set
            {
                if (imagePath != value)
                {
                    imagePath = value;
                    OnPropertyChanged(nameof(ImagePath));
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public ObservableCollection<Row> Rows { get; set; }
    
    public ScrollView()
    {
        InitializeComponent();
        Rows = new ObservableCollection<Row>
        {
            new Row { Name = "Item 1", Description = "Description 1", ImagePath = "path1" },
            new Row { Name = "Item 2", Description = "Description 2", ImagePath = "path2" }
        };
        BindingContext = this;
    }
    

}