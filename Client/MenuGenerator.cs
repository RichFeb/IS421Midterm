using CalculatorLib.Models;
using System;

namespace MidtermProject
{
    class MenuGenerator
    {
        public static MenuCollection GenerateMenu()
        {
            MenuCollection collection = new MenuCollection();

            Calculator calc = Calculator.GetInstance();

            return new MenuCollection()
            {
                Menus =
                {
                    new Menu()
                    {
                        MenuId = 1,
                        MenuItems =
                        {
                            new MenuItem()
                            {
                                Text = "Add",
                                Action = () => calc.HandleInput("Add"),
                                
                            },
                            new MenuItem()
                            {
                                Text = "Subtract",
                                Action = () => calc.HandleInput("Subtract"),
                            },
                            new MenuItem()
                            {
                                Text = "Multiply",
                                Action = () => calc.HandleInput("Multiply"),
                            },
                            new MenuItem()
                            {
                                Text = "Divide",
                                Action = () => calc.HandleInput("Divide"),
                            },
                            new MenuItem()
                            {
                                Text = "Square",
                                Action = () => calc.HandleInput("Square"),
                            },
                            new MenuItem()
                            {
                                Text = "Square Root",
                                Action = () => calc.HandleInput("Square Root"),
                            },
                        }
                    }
                }
            };
        }
    }
}

