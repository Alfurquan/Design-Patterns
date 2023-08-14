using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.Exercise
{
    public class ProductProxy : Product
    {
        private DbContext context;

        public ProductProxy(int id, DbContext context) : base(id)
        {
            this.context = context;
        }

        public override void SetName(string name)
        {
            base.SetName(name);
            context.MarkAsChanged(this);
        }

    }
}
