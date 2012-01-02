using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team_Manager
{
    public class Employee
    {
        public Employee(string name, Role role)
        {
            m_name = name;
            m_roles.Add(role);
        }

        private List<Role> m_roles;
        private string m_name;

        public void AddRole(Role role)
        {
            m_roles.Add(role);
        }
    }
}
