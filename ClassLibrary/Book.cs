using System.Reflection.Metadata.Ecma335;

namespace ClassLibrary
{
    public class Book
    {
        private int _id;
        private string _title;
        private double _price;


        public int Id
        {
            get { return _id; }
            set 
            { 
                if (!(value > 0))
                {
                    throw new ArgumentException("Id skal være større end 0");
                }

                _id = value; 
            
            }
                
        }

        public string Title
        {
            get =>  _title;
            set
            {
                if (!(value is not null))
                {
                    throw new ArgumentNullException("Der mangler en title");
                }

                if (!(value.Length >= 3))
                {
                    throw new ArgumentException("Title skal være mindst 3 tegn");
                }

                _title = value;
            }
        }


        public double Price
        {
            get => _price;
            set
            {
                if (!(0 < value && value <= 1200))
                {
                    throw new ArgumentException("Prisen skal være mere end 0 kr. og mindre end 1200 kr.");
                }

                _price = value;
            }

        }

        public Book()
        {

        }

        public Book(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Title)}={Title}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}