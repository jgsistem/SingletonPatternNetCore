Net Core 2.1 - Singleton Pattern

Se implementaron las siguientes clases en: SingletonPatternNetCore/Api/Controllers/CustomersController.cs


LoggerBasicSingleton
LoggerThreadSafe1Singleton
LoggerThreadSafe2Singleton
LoggerThreadSafe3Singleton
LoggerThreadSafe4LazySingleton

Se hace uso del Singleton en la función create de CustomersController

    {
            //Logic.BL.Common.Domain.Singleton.LoggerBasSingleton.Instance.Log("Inicio de función");
            //Logic.BL.Common.Domain.Singleton.LoggerThreadSafe1Singleton.Instance.Log("Inicio de función");
            //Logic.BL.Common.Domain.Singleton.LoggerThreadSafe2Singleton.Instance.Log("Inicio de función");
            //Logic.BL.Common.Domain.Singleton.LoggerThreadSafe3Singleton.Instance.Log("Inicio de función");
              Logic.BL.Common.Domain.Singleton.LoggerThreadSafe4LazySingleton.Instance.Log("Inicio Evento");

        ....

            return StatusCode(StatusCodes.Status201Created, new ApiStringResponseDto("Created!"));//Ok();
                Logic.BL.Common.Domain.Singleton.LoggerThreadSafe4LazySingleton.Instance.Log("Termino Evento Correctamente");
        
        .....
		
		 catch (Exception e)
            {
                Logic.BL.Common.Domain.Singleton.LoggerThreadSafe4LazySingleton.Instance.Log("Error Evento" + e.ToString());
			}
    }