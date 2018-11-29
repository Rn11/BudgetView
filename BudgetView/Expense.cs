using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetView
{
    class Expense
    {
        private DateTime datum;
        private double essen;
        private double games;
        private double monatlich;
        private double hardware;
        private double luxus;
        private double buecher;
        private double haushalt;
        private double sonstiges;

        public Expense(string[] input)
        {
            this.Essen = Convert.ToDouble(input[0]);
            this.Games = Convert.ToDouble(input[1]);
            this.Monatlich = Convert.ToDouble(input[2]);
            this.Hardware = Convert.ToDouble(input[3]);
            this.Luxus = Convert.ToDouble(input[4]);
            this.Buecher = Convert.ToDouble(input[5]);
            this.Haushalt = Convert.ToDouble(input[6]);
            this.Sonstiges = Convert.ToDouble(input[7]);

            Datum = DateTime.Now.Date;
        }
        public DateTime Datum
        {
            get
            {
                return datum.Date;
            }

            set
            {
                datum = value;
            }
        }

        public double Essen
        {
            get
            {
                return essen;
            }

            set
            {
                essen = value;
            }
        }

        public double Games
        {
            get
            {
                return games;
            }

            set
            {
                games = value;
            }
        }

        public double Monatlich
        {
            get
            {
                return monatlich;
            }

            set
            {
                monatlich = value;
            }
        }

        public double Hardware
        {
            get
            {
                return hardware;
            }

            set
            {
                hardware = value;
            }
        }

        public double Luxus
        {
            get
            {
                return luxus;
            }

            set
            {
                luxus = value;
            }
        }

        public double Buecher
        {
            get
            {
                return buecher;
            }

            set
            {
                buecher = value;
            }
        }

        public double Haushalt
        {
            get
            {
                return haushalt;
            }

            set
            {
                haushalt = value;
            }
        }

        public double Sonstiges
        {
            get
            {
                return sonstiges;
            }

            set
            {
                sonstiges = value;
            }
        }
    }
}
