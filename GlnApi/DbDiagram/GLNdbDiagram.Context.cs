//Global Location Number (GLN) Registry API
//Copyright (C) 2018  University Hospitals Plymouth NHS Trust
//
//You should have received a copy of the GNU Affero General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>. 
// 
// See LICENSE in the project root for license information.
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gln_registry_aspNet.DbDiagram
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GLNdbDiagramContainer : DbContext
    {
        public GLNdbDiagramContainer()
            : base("name=GLNdbDiagramContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<PrimaryContacts> PrimaryContacts { get; set; }
        public virtual DbSet<Directorate> Directorates { get; set; }
        public virtual DbSet<AdditionalContacts> AdditionalContacts { get; set; }
        public virtual DbSet<Extensions> Extensions { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<GlnAssociation> GlnAssociations { get; set; }
        public virtual DbSet<Gln> Glns { get; set; }
        public virtual DbSet<Ipr> Iprs { get; set; }
    }
}