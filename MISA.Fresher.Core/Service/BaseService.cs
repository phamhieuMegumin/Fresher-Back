﻿
using MISA.Fresher.Core.Attributes;
using MISA.Fresher.Core.Exceptions;
using MISA.Fresher.Core.Interfaces.Repository;
using MISA.Fresher.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.Core.Service
{
    public class BaseService<T> : IBaseService<T>
    {
        #region Field
        IBaseRepository<T> _repository;
        #endregion

        #region Constructor
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public int Insert(T entity)
        {
            Validate(entity);
            return _repository.Insert(entity);
        }

        public int Update(Guid entityId, T entity)
        {
            Validate(entity);
            return _repository.Update(entityId, entity);
        }
        /// <summary>
        /// Kiểm tra thông tin hợp lệ
        /// </summary>
        /// <param name="entity">Đối tượng cần kiểm tra</param>
        /// CreatedBy : PQHIEU (24/5/2021)
        protected virtual void Validate(T entity)
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributesRequired = property.GetCustomAttributes(typeof(Required), true);
                if (attributesRequired.Length > 0)
                {
                    var propertyValue = property.GetValue(entity);
                    var propertyType = property.PropertyType;
                    if (propertyType == typeof(string) && string.IsNullOrEmpty(propertyValue.ToString()))
                    {
                        var errorMessage = (attributesRequired[0] as Required)._msgError;
                        var fieldError = (attributesRequired[0] as Required)._fieldError;
                        throw new ValidateException(errorMessage, entity.GetType().GetProperty(fieldError).Name);
                    }
                }
            }
        }
        #endregion

    }
}
