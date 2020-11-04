using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DALef.Concrete
{
    public class CategoriesDalEf : ICategoriesDal
    {
        private readonly IMapper _mapper;

        public CategoriesDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<CategoriesDTO> GetAllCategories()
        {
            using (var entities = new IMDBEntities())
            {
                var categories = entities.Category.ToList();
                return _mapper.Map<List<CategoriesDTO>>(categories);
            }
        }


        public int CD(string category)
        {
            using (var entities = new IMDBEntities())
            {
                var categories = entities.Categories.SingleOrDefault(b => b.Category == category);
                return _mapper.Map<CategoriesDTO>(categories.CategoryID);
            }
        }
    }
    
}
