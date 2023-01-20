using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuotes
    {
        //public AddQuote addQuote;
        private string customerName;
        string quoteDate;
        Desk desk;
        int totalPrice;
        //string shipping;
        public DeskQuotes(string customerName, int width, int depth, int drawers, string material)
        {
            this.customerName = customerName;
            desk = new Desk(width, depth, drawers, material);
            DateTime currentDate= DateTime.Now;
            quoteDate = currentDate.ToString("MM/dd/yyyy");
            Width = desk.Width;
            Depth = desk.Depth;
            Drawers = desk.Drawers;
            Material = desk.Material;
            TotalPrice = Price();
        }
        public string CustomerName { get => customerName; }
        public int Width { get => desk.Width; set => desk.Width = value; }
        public int Depth { get => desk.Depth; set => desk.Depth = value; }
        public int Drawers { get => desk.Drawers; set => desk.Drawers = value; }
        public string Material { get => desk.Material; set => desk.Material = value; }
        public int TotalPrice { get => totalPrice;set => totalPrice = value; }
        public string QuoteDate { get => quoteDate; }

        public int Price()
        {
            int area = desk.Width * desk.Depth;
            int areaPrice = 0;
            if(area > 1000)
            {
                areaPrice = area - 1000;
            }

            int drawerPrice = desk.Drawers * 50;

            int materialPrice = 0;
            switch(desk.Material)
            {
                case "Laminate":
                    materialPrice = 100;
                    break;
                case "Oak":
                    materialPrice = 200;
                    break;
                case "Rosewood":
                    materialPrice = 300;
                    break;
                case "Veneer":
                    materialPrice = 125;
                    break;
                case "Pine":
                    materialPrice = 50;
                    break;
            }
            int price = 200 + drawerPrice + materialPrice + areaPrice;
            return price;

        }
    }
}
