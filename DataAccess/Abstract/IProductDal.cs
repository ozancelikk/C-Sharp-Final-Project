using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //PRODUCT İLE İLGİLİ VERİ TABANINDA YAPACAĞIM OPERASYONLARI İÇEREN INTERFACE ALAN 
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}   

//Code Refactoring: kodu iyileştirmek.
