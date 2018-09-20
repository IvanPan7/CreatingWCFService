using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class HotelBookingService : IHotelBookingService
    {
        //Implementacion del contrato
        public BookingResponse BookHotel(Reservation reservation)
        {
            BookingResponse Response = null;
            if (reservation.HotelName=="HotelA")
            {
                Response = new BookingResponse { IsApproved = true, BookingReference = "AR3254" };
            }
            else
            {
                Response = new BookingResponse { IsApproved = false, BookingReference = "null" };
            }
            return Response;
        }
        public bool Authenticate(User user)
        {
           
            if (user.NameUser == "Gustavo")
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public List<ElSalvadorHotels> GetHotelsList(User user)
        {
            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();

            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Hotel Colon",
                Category = "Pequeño Hotel",
                DepartmentLocation = "Usulutan"
            });
            if (user.NameUser == "admin")
            {
                return theList;
            }
            return null;
        }

        public List<ElSalvadorHotels> GetHotelsListByLocation(User user)
        {
            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();
            var result = theList;
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Hotel Colon",
                Category = "Pequeño Hotel",
                DepartmentLocation = "Usulutan"
            });
            if (user.Request != null)
            {
                try
                {
                    result = theList.Where(p => p.DepartmentLocation == user.Request.ToString()).ToList();
                }
                catch (Exception)
                {
                    result = null;
                }
                
            }
            return result;
        }

        public List<ElSalvadorHotels> GetHotelsListByCategory(User user)
        {
            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();
            var result = theList;
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                NameHotel = "Hotel Colon",
                Category = "Pequeño Hotel",
                DepartmentLocation = "Usulutan"
            });
            if (user.Request != null)
            {
                try
                {
                    result = theList.Where(p => p.Category == user.Request.ToString()).ToList();
                }
                catch (Exception)
                {
                    result = null;
                }
                
            }
            return result;
        }
    }
}
