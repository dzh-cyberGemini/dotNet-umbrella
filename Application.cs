using ProductCatalog.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog
{
    public class Application
    {
        private readonly Menu menu;

        public Application(Menu _menu)
        {
            menu = _menu;
        }
        public void Run(string[] args)
        {
            bool running = true;

            while (running)
            {
                running = menu.MainMenu();
            }
        }
    }
}
