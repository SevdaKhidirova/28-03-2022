using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28_03_2022_Task.Models
{
    /*Song class-ı olsun. Song-un Name, Genre, Singer(agregation) prop-ları olsun. 
     * Name max 100 uzunluqda set oluna bilər. Genre yalnız "Pop", 
     * "Rock", "Jazz", "Techno" bu value-lardan biri ola bilər.
     * Məsələn  "Classic" ola bilməz, yalnız göstərilənlərdən biri set olunmalıdır.*/

    //Song-un rating-ləri olsun. AddRating, GetAverageRating metodları ilə funksionallıq təmin olunsun.

    class Songs
    {
        private string _SongName;
        private string _Genre;
        private Singer _Singer;
        private double[] Ratings = new double[0];

        public Singer Singer
        {
            get
            {
                return _Singer;
            }
            set
            {
                _Singer = value;
            }
        }
        public string SongName
        {
            get
            {
                return _SongName;
            }

            set
            {
                if (value.Length <= 100)
                {
                    _SongName = value;
                }
            }
        }
        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
                {
                    _Genre = value;
                }
            }
        }

        public void AddRating(double rating)
        {
            if (rating >= 0 && rating <= 5)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
        }

        public double GetAverageRating()
        {
            return Ratings.Average();
        }
    }
}
