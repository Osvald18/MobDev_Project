using System.Collections.ObjectModel;
using System.Windows.Input;
using Proj.Models;
using Microsoft.Maui.Controls;


namespace Proj.ViewModels
{
    public class LostItemsViewModel
    {
        public ObservableCollection<LostItem> LostItems { get; set; }

        public ICommand ItemTappedCommand { get; }

        public LostItemsViewModel()
        {
            LostItems = new ObservableCollection<LostItem>
            {
                new LostItem { Image = "bag.jpg", Name = "Red Bag", Category = "Bags", Description = "Found at the library", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe" },
                new LostItem { Image = "headphones1.jpg", Name = "Sony Headphones", Category = "Electronics", Description = "Found in Room 101", Date = "February 14, 2024", Location = "Bunzel Building", Founded = "John Doe" },
                new LostItem { Image = "phone.jpg", Name = "Iphone", Category = "Electronics", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe" },
                new LostItem { Image = "headphones2.jpg", Name = "Bose", Category = "Electronics", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe"  },
                new LostItem { Image = "brownbottle.jpg", Name = "AquaFlask", Category = "Bottles", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe"  },
                new LostItem { Image = "shirt.jpg", Name = "Brown t-shirt", Category = "Bags", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe"  },
                new LostItem { Image = "necklace.jpg", Name = "Necklace", Category = "Jewelry", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe"  },
                new LostItem { Image = "bag2.jpg", Name = "Jansport Bag", Category = "Bags", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe" },
                new LostItem { Image = "wallet1.jpg", Name = "Wallet", Category = "Miscellaneous", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe"  },
                new LostItem { Image = "bluebottle.jpg", Name = "Aquaflask blue bottle", Category = "Bottles", Description = "Found in Room 101", Date = "Januray 14, 2024", Location = "Bunzel Building", Founded = "John Doe" }
                // Add more items...
            };

            ItemTappedCommand = new Command<LostItem>(async (item) =>
            {
                
                var image = Uri.EscapeDataString(item.Image);
                var name = Uri.EscapeDataString(item.Name);
                var desc = Uri.EscapeDataString(item.Description);
                var date = Uri.EscapeDataString(item.Date);
                var location = Uri.EscapeDataString(item.Location);
                var founded = Uri.EscapeDataString(item.Founded);
                
                await Shell.Current.GoToAsync($"itemdetails?image={Uri.EscapeDataString(item.Image)}&name={Uri.EscapeDataString(item.Name)}&desc={Uri.EscapeDataString(item.Description)}&date={Uri.EscapeDataString(item.Date)}&location={Uri.EscapeDataString(item.Location)}&founded={Uri.EscapeDataString(item.Founded)}");
                
            });
        }
    }
}

    
 