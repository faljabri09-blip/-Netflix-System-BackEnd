using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MoviesForm
{
  
        public class User
        {
            public string Name { get; set; }
            public int WatchCount { get; private set; }

            public User(string name)
            {
                Name = name;
                WatchCount = 0;
            }

            public void WatchMovie(Movie movie)
            {
                WatchCount++;
                MessageBox.Show($"{Name} is watching {movie.Title}");
            }

            public void RateMovie(Movie movie, int rate)
            {
                if (rate >= 1 && rate <= 10)
                {
                    movie.Rating = rate;
                    MessageBox.Show($"{Name} rated {movie.Title}: {rate}");
                }
                else
                {
                    MessageBox.Show("Invalid rating. Must be 1–10.");
                }
            }
        }

    }

