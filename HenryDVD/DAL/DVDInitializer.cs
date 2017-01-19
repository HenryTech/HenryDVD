using HenryDVD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HenryDVD.DAL
{
    public class DVDInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<DVDContext>
    {
        protected override void Seed(DVDContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="Miller's Crossing",Director="Coen Bros.",Writer="Coen Bros.",Location="Binder 1" },
                new Movie {Title="Mirrormask",Director="Dave McKean",Writer="Neil Gaiman",Location="Binder 1" },
                new Movie {Title="O Brother, Where Art Thou?",Director="Coen Bros.",Writer="Coen Bros.",Location="Binder 1" },
                new Movie {Title="Phish: Live in Las Vegas",Director="na",Writer="na",Location="Binder 1" },
                new Movie {Title="Phish: Bittersweet Motel",Director="Todd Phillips",Writer="na",Location="Binder 1" },
                new Movie {Title="Pink Floyd: Live At Pompeii Director's Cut",Director="Adrian Maben",Writer="na",Location="Binder 1" },
                new Movie {Title="The Princess Bride",Director="Rob Reiner",Writer="William Goldman",Location="Binder 1" },
                new Movie {Title="The Professional",Director="Luc Besson",Writer="Luc Besson",Location="Binder 1" },
                new Movie {Title="Pulp Fiction",Director="Quentin Tarantino",Writer="Quentin Tarantino",Location="Binder 1" },
                new Movie {Title="Rent",Director="Chris Columbus",Writer="Stephen Chbosky",Location="Binder 1" },
                new Movie {Title="Requiem For A Dream",Director="Darren Aronofsky",Writer="Hubert Selby, Jr.",Location="Binder 1" },
                new Movie {Title="Reservoir Dogs",Director="Quentin Tarantino",Writer="Quentin Tarantino",Location="Binder 1" },
                new Movie {Title="Serenity",Director="Joss Whedon",Writer="Joss Whedon",Location="Binder 1" },
                new Movie {Title="Sleepy Hollow",Director="Tim Burton",Writer="Kevin Yagher",Location="Binder 1" },
                new Movie {Title="Sin City",Director="Robert Rodriguez",Writer="Frank Miller",Location="Binder 1" },
                new Movie {Title="Stargate",Director="Roland Emmerich",Writer="Dean Devlin",Location="Binder 1" },
                new Movie {Title="Dr. Strangelove",Director="Stanley Kubrick",Writer="Stanley Kubrick",Location="Binder 1" },
                new Movie {Title="Team America: World Police",Director="Trey Parker",Writer="Matt Stone",Location="Binder 1" },
                new Movie {Title="Thank You For Smoking",Director="Jason Reitman",Writer="Jason Reitman",Location="Binder 1" },
                new Movie {Title="Time Bandits",Director="Terry Gilliam",Writer="Michael Palin",Location="Binder 1" },
                new Movie {Title="Toy Story",Director="John Lasseter",Writer="John Lasseter",Location="Binder 1" },
                new Movie {Title="Toy Story 2",Director="John Lasseter",Writer="John Lasseter",Location="Binder 1" },
                new Movie {Title="Traffic",Director="Stephen Soderbergh",Writer="Stephen Gaghan",Location="Binder 1" },
                new Movie {Title="True Romance",Director="Tony Scott",Writer="Quentin Tarantino",Location="Binder 1" },
                new Movie {Title="The Usual Suspects",Director="Brian Singer",Writer="Christopher McQuarrie",Location="Binder 1" }
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();

            var actors = new List<Actor>
                {
                new Actor {MovieID=1,ActorName="Gabriel Byrne" },
                new Actor {MovieID=1,ActorName="Albert Finney" },
                new Actor {MovieID=1,ActorName="John Turturro" },
                new Actor {MovieID=2,ActorName="Stephanie Leonidas" },
                new Actor {MovieID=2,ActorName="Jason Barry" },
                new Actor {MovieID=2,ActorName="Rob Brydon" },
                new Actor {MovieID=3,ActorName="George Clooney" },
                new Actor {MovieID=3,ActorName="John Turturro" },
                new Actor {MovieID=3,ActorName="Tim Blake Nelson" },
                new Actor {MovieID=3,ActorName="John Goodman" },
                new Actor {MovieID=3,ActorName="Holly Hunter" },
                new Actor {MovieID=4,ActorName="no actors" },
                new Actor {MovieID=5,ActorName="no actors" },
                new Actor {MovieID=6,ActorName="no actors" },
                new Actor {MovieID=7,ActorName="Cary Elwes" },
                new Actor {MovieID=7,ActorName="Mandy Patinkin" },
                new Actor {MovieID=7,ActorName="Robin Wright" },
                new Actor {MovieID=8,ActorName="Jean Reno" },
                new Actor {MovieID=8,ActorName="Gary Oldman" },
                new Actor {MovieID=8,ActorName="Natalie Portman" },
                new Actor {MovieID=9,ActorName="John Travolta" },
                new Actor {MovieID=9,ActorName="Uma Thurman" },
                new Actor {MovieID=9,ActorName="Samuel L. Jackson" },
                new Actor {MovieID=9,ActorName="Bruce Willis" },
                new Actor {MovieID=10,ActorName="Taye Diggs" },
                new Actor {MovieID=10,ActorName="Wilson Jermaine Heredia" },
                new Actor {MovieID=10,ActorName="Rosario Dawson" },
                new Actor {MovieID=11,ActorName="Ellen Burstyn" },
                new Actor {MovieID=11,ActorName="Jared Leto" },
                new Actor {MovieID=11,ActorName="Jennifer Connelly" },
                new Actor {MovieID=12,ActorName="Harvey Keitel" },
                new Actor {MovieID=12,ActorName="Tim Roth" },
                new Actor {MovieID=12,ActorName="Michael Madsen" },
                new Actor {MovieID=13,ActorName="Nathan Fillion" },
                new Actor {MovieID=13,ActorName="Gina Torres" },
                new Actor {MovieID=13,ActorName="Chiwetel Ejiofor" },
                new Actor {MovieID=14,ActorName="Johnny Depp" },
                new Actor {MovieID=14,ActorName="Christina Ricci" },
                new Actor {MovieID=15,ActorName="Bruce Willis" },
                new Actor {MovieID=15,ActorName="Mickey Rourke" },
                new Actor {MovieID=15,ActorName="Clive Owen" },
                new Actor {MovieID=15,ActorName="Jessica Alba" },
                new Actor {MovieID=16,ActorName="Kurt Russell" },
                new Actor {MovieID=16,ActorName="James Spader" },
                new Actor {MovieID=17,ActorName="Peter Sellers" },
                new Actor {MovieID=17,ActorName="George C. Scott" },
                new Actor {MovieID=18,ActorName="Trey Parker" },
                new Actor {MovieID=18,ActorName="Matt Stone" },
                new Actor {MovieID=19,ActorName="Aaron Eckhart" },
                new Actor {MovieID=19,ActorName="William H. Macy" },
                new Actor {MovieID=19,ActorName="Cameron Bright" },
                new Actor {MovieID=19,ActorName="Maria Bello" },
                new Actor {MovieID=19,ActorName="Sam Elliott" },
                new Actor {MovieID=19,ActorName="Rob Lowe" },
                new Actor {MovieID=19,ActorName="Robert Duvall" },
                new Actor {MovieID=19,ActorName="Katie Holmes" },
                new Actor {MovieID=19,ActorName="Adam Brody" },
                new Actor {MovieID=20,ActorName="John Cleese" },
                new Actor {MovieID=20,ActorName="Sean Connery" },
                new Actor {MovieID=20,ActorName="Shelley Duvall" },
                new Actor {MovieID=21,ActorName="Tom Hanks" },
                new Actor {MovieID=21,ActorName="Tim Allen" },
                new Actor {MovieID=22,ActorName="Tim Allen" },
                new Actor {MovieID=22,ActorName="Tom Hanks" },
                new Actor {MovieID=23,ActorName="Michael Douglas" },
                new Actor {MovieID=23,ActorName="Don Cheadle" },
                new Actor {MovieID=23,ActorName="Benecio DelToro" },
                new Actor {MovieID=23,ActorName="Dennis Quaid" },
                new Actor {MovieID=23,ActorName="Catherine Zeta-Jones" },
                new Actor {MovieID=24,ActorName="Patricia Arquette" },
                new Actor {MovieID=24,ActorName="Dennis Hopper" },
                new Actor {MovieID=24,ActorName="Val Kilmer" },
                new Actor {MovieID=24,ActorName="Gary Oldman" },
                new Actor {MovieID=24,ActorName="Brad Pitt" },
                new Actor {MovieID=24,ActorName="Christopher Walken" },
                new Actor {MovieID=24,ActorName="Christian Slater" },
                new Actor {MovieID=25,ActorName="Gabriel Byrne" },
                new Actor {MovieID=25,ActorName="Stephen Baldwin" },
                new Actor {MovieID=25,ActorName="Chazz Palminteri" },
                new Actor {MovieID=25,ActorName="Kevin Pollak" },
                new Actor {MovieID=25,ActorName="Kevin Spacey" },
                new Actor {MovieID=25,ActorName="Pete Postlethwaite" }
                };
            actors.ForEach(s => context.Actors.Add(s));
            context.SaveChanges();


        }
    }
}