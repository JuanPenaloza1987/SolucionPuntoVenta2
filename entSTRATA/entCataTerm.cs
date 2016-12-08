using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRATA.Entities
{
   public class entCataTerm
    {
        #region propieties
        public string ter_CreditCard { get; set; }
        public string ter_CardName { get; set; }
        public string ter_acctcode { get; set; }
        public bool ter_valido { get; set; }

        #endregion

        #region methods
        public entCataTerm()
        { }
        public entCataTerm
        (string ter_CreditCard, string ter_CardName, string ter_acctcode, bool ter_valido
        )
        {
            this.ter_CreditCard = ter_CreditCard;
            this.ter_CardName = ter_CardName;
            this.ter_acctcode = ter_acctcode;
            this.ter_valido = ter_valido;
        }
        #endregion
    }
}
