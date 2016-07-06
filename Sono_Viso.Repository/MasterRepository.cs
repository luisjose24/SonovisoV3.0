using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sono_Viso.Repository
{
    public abstract class MasterRepository
    {
        public readonly Sono_VisoContext _context;

        protected MasterRepository()
        {
            if (_context == null)
            {
                _context= new Sono_VisoContext();
            }
        }

        protected Sono_VisoContext Context
        {
            get { return _context; }
        }
    }
}
