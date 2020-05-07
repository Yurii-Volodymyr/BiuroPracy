using BiuroPracy.BusinessLogic.Communication;
using BiuroPracy.BusinessLogic.ModelDTO;

namespace BiuroPracy.BusinessLogic.Api.Interface
{
   public interface IBiuroPracyApi
    {
        void TestNHibernate();
        ListIdNamePairServiceResponse GetProfessions();
        ListIdNamePairServiceResponse GetContracts();

        ServiceResponse AddEmployee(EmployeeDto employee);
        EmployeesServiceResponse GetEmployees();
        ListIdNamePairServiceResponse GetCity();
        ListIdNamePairServiceResponse GetCountry();
    }
}
