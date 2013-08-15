﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coevery.Entities.ViewModels;
using Orchard;
using Orchard.ContentManagement;

namespace Coevery.Entities.Services {
    public interface IFieldService : IDependency {
        void CreateCheck(string entityName, AddFieldViewModel viewModel, IUpdateModel updateModel);
        //void Create(string entityName, AddFieldViewModel viewModel, IUpdateModel updateModel);
        void Delete(string name, string parentname);
    }
}
