using Microsoft.AspNetCore.Mvc;
using Rusuz.Services.Foundations.Categories;
using Rusuz.Services.Foundations.Sektions;

namespace Rusuz.Services.Orchestrations.Categories
{
    public class RetrieveCategoryWithSection: IRetrieveCategoryWithSection
    {
        private readonly ICategoryService categoryService;
        private readonly ISectionService sectionService;

        public RetrieveCategoryWithSection(
            ICategoryService categoryService, 
            ISectionService sectionService)
        {
            this.categoryService = categoryService;
            this.sectionService = sectionService;
        }

       
    }
}
