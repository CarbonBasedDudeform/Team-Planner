using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team_Manager
{
    public class Job
    {
        private string m_title;
        public string Title
        {
            set { m_title = value; }
            get { return m_title; }
        }

        private string m_location;
        public string Location
        {
            set { m_location = value; }
            get { return m_location; }
        }

        private DateTime m_startDate;
        public DateTime StartDate
        {
            set { m_startDate = value; }
            get { return m_startDate; }
        }

        private DateTime m_endDate;
        public DateTime EndDate
        {
            set { m_endDate = value; }
            get { return m_endDate; }
        }

        private TimeSpan m_length;
        public TimeSpan LengthOfJob
        {
            set { m_length = value; }
            get { return m_length; }
        }

        public List<Role> RequiredWorkforce = new List<Role>();
    }
}
