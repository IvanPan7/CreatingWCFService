using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            if (!IsHotelNameValid(reservation))
            {
                //Throw una FaultExecption
                //Throw FaultExeption<T>
                
               /* throw new FaultException<ReservationFault>(new ReservationFault {
                    HotelName = reservation.HotelName,
                    ErrorCode = "123"
                }); */
            }
            if (reservation.HotelName=="HotelA")
            
            {
                Response = new BookingResponse
                {
                    IsApproved = true,
                    BookingReference = "AR3254"
                };
            }
            else
            {
                Response = new BookingResponse
                {
                    IsApproved = false,
                    BookingReference = "null"
                };
            }
            return Response;
        }

        private bool IsHotelNameValid(Reservation reservation)
        {
            return string.Equals(reservation.HotelName, "ABC");
            //throw una Fault Execption
        }

        public bool Authenticate(User user)
        {
           
            if (user.NameUser == "IvanPan7")
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
                IDHotel = 1,
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 2,
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 3,
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 4,
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 5,
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 6,
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
            //Implementar fault exception
            if (string.IsNullOrEmpty(user.Request))
            {
                throw new FaultException("El código de área no puede estar vacío");
            }
            

            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();
            var result = theList;
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 1,
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 2,
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 3,
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 4,
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 5,
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 6,
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
            if (theList==null)
            {
                throw new FaultException("No hay datos de hoteles");
            }
            return result;
        }

        public List<ElSalvadorHotels> GetHotelsListByCategory(User user)
        {
            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();
            var result = theList;
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 1,
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 2,
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 3,
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 4,
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 5,
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 6,
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

        public List<ElSalvadorHotels> GetHotelsListByID(User user)
        {
            List<ElSalvadorHotels> theList = new List<ElSalvadorHotels>();
            var result = theList;
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 1,
                NameHotel = "Sheraton Presidente",
                Category = "Gran Hotel",
                DepartmentLocation = "San Salvador"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 2,
                NameHotel = "Decameron",
                Category = "Gran Hotel",
                DepartmentLocation = "La Libertad"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 3,
                NameHotel = "Tropico Inn",
                Category = "Gran Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 4,
                NameHotel = "Confort Inn",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 5,
                NameHotel = "Casino Migueleño",
                Category = "Mediano Hotel",
                DepartmentLocation = "San Miguel"
            });
            theList.Add(new ElSalvadorHotels()
            {
                IDHotel = 6,
                NameHotel = "Hotel Colon",
                Category = "Pequeño Hotel",
                DepartmentLocation = "Usulutan"
            });
            if (user.Request != null)
            {
                try
                {
                    int request = int.Parse(user.Request);
                    result = theList.Where(p => p.IDHotel== request).ToList();
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
