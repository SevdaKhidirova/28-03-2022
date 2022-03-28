using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _28_03_2022_Task.Models
{
    //Singer class-ı olsun. Singer-in Name, Surname, Age prop-ları olsun. Name və Surname max 100 uzunluqda set oluna bilər. Age max 170 ola bilər.
    class Singer
    {
       // [MaxLength(100)]
        private string _Name;
        private string _Surname;
        private int _Age;

        public string Name {
            get
            {
                return _Name;
            }

            set
            {
                if (value.Length <= 100)
                {
                    _Name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _Surname;
            }

            set
            {
                if (value.Length <= 100)
                {
                    _Surname = value;
                }
            }
        }

        public int Age {
            get
            {
                return _Age;
            }

            set
            {
                if(value>0 && value <= 170)
                {
                    _Age = value;
                }
            }
        }
    }
}
