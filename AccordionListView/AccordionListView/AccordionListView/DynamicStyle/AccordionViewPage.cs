using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AccordionListView.DynamicStyle
{
    public class ShoppingCart
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        
    }
    public class Section
    {
        public string Title { get; set; }
        public IEnumerable<ShoppingCart> List { get; set; }
      
    }

    public class ViewModel
    {
        public IEnumerable<Section> List { get; set; }
    }
   
    public class AccordionViewPage : ContentPage
    {
        public AccordionViewPage()
        {
            this.Title = "Accordion";
             
            var template = new DataTemplate(typeof(DefaultTemplate));
            var view = new AccordionView(template);
            view.SetBinding(AccordionView.ItemsSourceProperty, "List");
            view.Template.SetBinding(AccordionSectionView.TitleProperty, "Title");
            view.Template.SetBinding(AccordionSectionView.ItemsSourceProperty, "List");

            view.BindingContext =
                new ViewModel
                {
                    List = new List<Section> {
                        
                       new Section
                       {
                           Title="Cosmetics and Perfumes",
                           List =new List<ShoppingCart>
                           {
                               new ShoppingCart{ Date=DateTime.UtcNow,Amount= 10.56}
                           }
                       },
                      
                        new Section
                        {
                            Title = "Perfumes And Cosmetics",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                        new Section
                        {
                            Title = "Electronic & Multimedia",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                        new Section
                        {
                            Title = "Phones & Accessories",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                        new Section
                        {
                            Title = "Computers & Buro",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                        new Section
                        {
                            Title = "Sports & OutDoor",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                        new Section
                        {
                            Title = "Haus & Garden",
                            List = new List<ShoppingCart> {
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 },
                                new ShoppingCart { Date = DateTime.UtcNow, Amount = 10.05 }
                            }
                        },
                    }
                };
            this.Content = view;
        }
    }
}
