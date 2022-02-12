spacio de nombres  a__Ejemplo_1 . datos ;

 clase  pública WeatherForecastService
{
     cadena de solo lectura estática  privada [] Resúmenes = nuevo []   
    {
        " Congelante " , " Tonificante " , " Frío " , " Fresco " , " Suave " , " Cálido " , " Balsámico " , " Caliente " , " Sofocante " , " Abrasador "
    };

     tarea pública < WeatherForecast []> GetForecastAsync ( DateTime  startDate )
    {
         tarea de retorno . FromResult ( Enumerable . Range ( 1 , 5 ). Select ( index  =>  new  WeatherForecast
        {
            Fecha  = fecha  de inicio . AddDays ( índice ),
            TemperaturaC  =  Aleatorio . Compartido _ Siguiente ( - 20 , 55 ),
            Resumen  =  Resúmenes [ Aleatorio . Compartido _ Siguiente ( Resúmenes . Longitud )]
        }). a la matriz ());
    }
}
