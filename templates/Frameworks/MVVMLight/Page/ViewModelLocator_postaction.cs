﻿public class ViewModelLocator
{
    public ViewModelLocator()
    {
        //^^
        Registeruct.ItemName(navigationService);
    }

    public uct.ItemNameViewModel uct.ItemNameViewModel => ServiceLocator.Current.GetInstance<uct.ItemNameViewModel>();
    //{[{
    public void Registeruct.ItemName(NavigationServiceExt navigationService)
    {
        SimpleIoc.Default.Register<uct.ItemNameViewModel>();
        navigationService.Configure(typeof(uct.ItemNameViewModel).FullName, typeof(uct.ItemNameView));
    }
    //}]}
}