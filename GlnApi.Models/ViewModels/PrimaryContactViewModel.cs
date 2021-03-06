//Global Location Number (GLN) Registry API
//Copyright (C) 2018  University Hospitals Plymouth NHS Trust
//
//You should have received a copy of the GNU Affero General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>. 
// 
// See LICENSE in the project root for license information.
﻿namespace GlnApi.Models.ViewModels
{
    public class PrimaryContactViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Function { get; set; }
        public string Salutation { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public bool Active { get; set; }
        public int Version { get; set; }
        public override string ToString()
        {
            return $"Contact Id: {Id}, Version: {Version}, {Name}, Email: {Email}.";
        }
    }
}