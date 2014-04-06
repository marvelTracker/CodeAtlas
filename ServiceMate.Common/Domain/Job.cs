using System;
using System.Collections.Generic;

namespace ServiceMate.Common.Domain
{
    public class Job:BaseEntity
    {
        public virtual Consumer Consumer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual Service Service
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual Quotation Quotation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime JobDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime ExpiredDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public JobStatusType JobStatusType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Description
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Suburb Suburb
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IList<Quotation> QuotationList { get; set; }
    }
}
