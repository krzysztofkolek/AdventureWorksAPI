namespace AdventureWorks.UOW.Builder
{
    using System;
    using Model.Person;

    public class UserTitleViewModelBuilder : Builder<UserTitleViewModel>
    {
        private String _title { get; set; }

        public UserTitleViewModelBuilder SetTitle(String title)
        {
            _title = title;
            return this;
        }
        
        public override UserTitleViewModel Build()
        {
            UserTitleViewModel model = new UserTitleViewModel();

            model.Title = _title;

            return model;
        }
    }
}
