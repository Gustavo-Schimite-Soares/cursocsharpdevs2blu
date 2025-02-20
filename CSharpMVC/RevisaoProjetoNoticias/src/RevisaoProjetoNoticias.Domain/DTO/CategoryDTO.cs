﻿using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.DTO
{
    public class CategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<NewsDTO>? newsList { get; set; }

        public Category mapToEntity()
        {
            return new Category
            {
                Id = id,
                Name = name
            };
        }
        public CategoryDTO mapToDTO(Category category)
        {
            return new CategoryDTO
            {
                id = category.Id,
                name = category.Name,
                /*newsList = category.NewsList.Select(c => new NewsDTO()
                {
                    id = c.Id,
                    title = c.Title,
                    description = c.Description,
                    categoryId = c.CategoryId,
                    createdOn = c.CreatedOn,
                    published = c.Published,
                    category = new CategoryDTO()
                    {
                        id = c.Category.Id,
                        name = c.Category.Name
                    }
                }).ToList(),*/
            };
        }
    }
}
