using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace VisugDemo
{
    public class PlayPage : ContentPage
    {
        public PlayPage()
        {
            Grid grid = new Grid()
            {
                ColumnDefinitions = new ColumnDefinitionCollection()
                {
                    new ColumnDefinition() {Width = GridLength.Auto},
                    new ColumnDefinition() {Width = GridLength.Auto},
                },
                RowDefinitions = new RowDefinitionCollection()
                {
                    new RowDefinition(){Height = GridLength.Auto},
                    new RowDefinition(){Height = GridLength.Auto},
                }
            };

            Label l = new Label() {Text = "1"};
            

            grid.Children.Add(l, 0, 0);
            grid.Children.Add(new Label() { Text = "2" }, 1, 0);
            grid.Children.Add(new Label() { Text = "4" }, 1, 1);
            Grid.SetColumnSpan(l, 2);

            


            Content = new StackLayout
            {
                Children = {
					grid,
				}
            };
        }
    }
}
