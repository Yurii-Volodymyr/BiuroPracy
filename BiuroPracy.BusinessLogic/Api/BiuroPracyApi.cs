using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiuroPracy.BusinessLogic.Api.Interface;
using BiuroPracy.BusinessLogic.Communication;
using BiuroPracy.BusinessLogic.Extensions;
using BiuroPracy.BusinessLogic.Logic;
using BiuroPracy.BusinessLogic.ModelDTO;
using BiuroPracy.BusinessLogic.NHibernate;
using BiuroPracyDomain;
using NHibernate;
using NHibernate.Linq;

namespace BiuroPracy.BusinessLogic.Api
{
    public class BiuroPracyApi : BaseApi, IBiuroPracyApi
    {
        public void TestNHibernate()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    using (var transaction = session.BeginTransaction())

                    {
                        var ksiazka = session.Get<Ksiazka>(2);
                    }
                }
            }
            catch (Exception e)
            {
            }

        }
        public ListIdNamePairServiceResponse GetProfessions()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var professions = session.Query<Profession>()
                        .Select(x =>
                        new IdNamePair
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = professions
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public ListIdNamePairServiceResponse GetContracts()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var contracts = session.Query<Contract>()
                        .Select(x =>
                        new IdNamePair
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = contracts
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }

        public ServiceResponse AddEmployee(EmployeeDto employee)
        {
            using (var session = NHibernateBase.Session)//tworzymy obiket połaćzenia do bazy danych
            {
                using (var transaction = session.BeginTransaction()) //Tworzymym obiket tranzakcji
                {
                    try
                    {
                        var employeeAdd = employee.ToEmployee();
                        session.Save(employeeAdd);
                        transaction.Commit();
                        var email = new EmailManager();
                        email.SendEmail("Dodano pracownika", "Hasło: " + employeeAdd.Password+ "    Gratulacje jesteś z nami!!!", employeeAdd.Email);
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        return new ServiceResponse()
                        {
                            Errors = e.StackTrace + "  " + e.Message,
                            Success = false
                        };
                    }
                }
            }
            return new ServiceResponse();
        }
        public EmployeesServiceResponse GetEmployees()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var employees = session.Query<Employee>()
                        .Select(x =>
                            new EmployeeDto()
                            {
                                Email = x.Email,
                                Name = x.Name,
                                Surename = x.Surname,
                                DateOfBirth= x.DateOfBirth,
                            }).ToList();
                    return new EmployeesServiceResponse()
                    {
                        Data=employees
                    };

                }
            }
            catch (Exception e)
            {
                return new EmployeesServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }
        public ListIdNamePairServiceResponse GetCity()
        {
            try
            {
                using(var session = NHibernateBase.Session)
                {
                    var city = session.Query<City>()
                        .Select(x =>
                        new IdNamePair
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = city
                    };
                }
            }
            catch (Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }
        public ListIdNamePairServiceResponse GetCountry()
        {
            try
            {
                using (var session = NHibernateBase.Session)
                {
                    var country = session.Query<Country>()
                        .Select(x =>
                        new IdNamePair
                        {
                            Id = x.Id,
                            Name = x.Name
                        }).ToList();
                    return new ListIdNamePairServiceResponse()
                    {
                        Data = country
                    };
                }
            }
            catch(Exception e)
            {
                return new ListIdNamePairServiceResponse()
                {
                    Errors = e.StackTrace + " " + e.Message,
                    Success = false
                };
            }
        }
    }
}
