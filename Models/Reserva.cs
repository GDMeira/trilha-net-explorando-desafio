using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2.Models
{
    public class Reserva
    {
        private List<Pessoa> _guests = new List<Pessoa>();

        private Suite _suite = new Suite("", 0, 0M);

        public Reserva(int reservedDays) 
        {
            this.ReservedDays = reservedDays;
   
        }
        public int ReservedDays{get; set;}

        public void GuestsRegistration(List<Pessoa> guests) {
            _guests = guests;
        }

        public void SuiteRegistration(Suite suite) {
            if (suite.Capacity >= _guests.Count) {
                _suite = suite;
            } else {
                throw new NotSupportedException("Suite incompatível com o número de hóspedes.");
            }
        }

        public int GetGuestsNumber() {
            return _guests.Count;
        }

        public decimal CalculateReservationPrice() {
            if (ReservedDays >= 10) {
                return _suite.DailyRate * ReservedDays * 0.9M;
            } else {
                return _suite.DailyRate * ReservedDays;
            }
        }
    }
}