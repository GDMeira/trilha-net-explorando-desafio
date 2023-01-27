using Desafio_2.Models;
using System.Text;

Pessoa p1 = new Pessoa("Gabriel", "Delgado");
Pessoa p2 = new Pessoa("Gabriela", "Maria");

List<Pessoa> guests = new List<Pessoa>();

guests.Add(p1);
guests.Add(p2);

Suite premiumSuite = new Suite("Premium", 1, 40.5M);

Reserva bestWeekendEver = new Reserva(10);
bestWeekendEver.GuestsRegistration(guests);
bestWeekendEver.SuiteRegistration(premiumSuite);

Console.WriteLine($"Hóspedes: {bestWeekendEver.GetGuestsNumber()}");
Console.WriteLine($"Total a pagar: {bestWeekendEver.CalculateReservationPrice()}");

