using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;


namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            var customMap = new CustomMap()
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var pin = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.481679, -70.722478),
                    Label = "Feria Costanera Norte, Cerrillos",
                    Address = "Desde José María Caro a Lo Errázuriz. Martes y Viernes",
                },

            };

            var pin002 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.481478, -70.68956),
                    Label = "Feria Avenida Cinco, Cerrillos",
                    Address = "Desde Buzeta a San Andrés. Martes y Viernes",
                },

            };

            var pin003 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.49439, -70.715706),
                    Label = "Feria Salomón Sack, Cerrillos",
                    Address = "Desde Rapa Nui a Comercio. Martes y Viernes",
                },

            };

            var pin004 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.491097, -70.724632),
                    Label = "Feria Pedro Lagos Palacios, Cerrillos",
                    Address = "Desde Lo Errázuriz a Santa Ana. Jueves y Domingos",
                },

            };

            var pin005 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.500107, -70.724857),
                    Label = "Feria Santa Teresita, Cerrillos",
                    Address = "Desde Buin a 14 de Octubre. Miércoles y Sábados"
                },
            };

            var pin006 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.502191, -70.73123),
                    Label = "Feria Mirador, Cerrillos",
                    Address = "Desde Divino Maestro a Las Torres. Miércoles y Sábados"
                },
            };

            var pin007 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.510127, -70.734304),
                    Label = "Feria 5 de Abril, Cerrillos",
                    Address = "Desde Reinosa a Los Tilos. Jueves y Domingos"
                },
            };

            var pin008 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.416559, -70.765139),
                    Label = "Feria Mares de Chile, Cerro Navia",
                    Address = "Desde Costanera Sur a Las Fragatas. Miércoles y Sábados"
                },
            };

            var pin009 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.416989, -70.749604),
                    Label = "Feria Salvador Gutiérrez, Cerro Navia",
                    Address = "Desde La Estrella a Rolando Peterson. Jueves y Domingos"
                },
            };

            var pin010 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.423723, -70.751642),
                    Label = "Feria La Estrella, Cerro Navia",
                    Address = "Desde Mapocho a La Hondonada. Martes y Viernes"
                },
            };

            var pin011 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.415019, -70.740012),
                    Label = "Feria La Capilla, Cerro Navia",
                    Address = "Desde Huelén a Resbalón. Martes y Viernes"
                },
            };


            var pin012 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.423007, -70.738596),
                    Label = "Feria Mapocho, Cerro Navia",
                    Address = "Desde Huelén a Resbalón. Miércoles y Sábados"
                },
            };

            var pin013 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.433769, -70.736064),
                    Label = "Feria Thomas Alva Edison, Cerro Navia",
                    Address = "Desde Jorge Washington a Estados Unidos. Jueves y Domingos"
                },
            };


            var pin014 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.419747, -70.729584),
                    Label = "Feria Salvador Gutiérrez, Cerro Navia",
                    Address = "Desde 3 de Julio a Santos Medel. Jueves y Domingos"
                },
            };

            var pin015 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.426544, -70.723795),
                    Label = "Feria Cauquenes, Cerro Navia",
                    Address = "Desde Lo López a Hipólito Salas. Miércoles y Sábados"
                },
            };

            var pin016 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.436497, -70.724849),
                    Label = "Feria Camino de Loyola, Cerro Navia",
                    Address = "Desde Las Madreselvas a Neptuno. Martes y Domingos"
                },
            };


            var pin017 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.417266, -70.718023),
                    Label = "Feria Heriberto Rojas, Cerro Navia",
                    Address = "Desde Lo López a Neptuno. Martes y Domingos"
                },
            };

            var pin018 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.368004, -70.688287),
                    Label = "Feria El Cuzco, Conchalí",
                    Address = "Desde Independencia a Florencia. Sábados"
                },
            };

            var pin019 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.368004, -70.688287),
                    Label = "Feria Cardenal Caro, Conchalí",
                    Address = "Desde Los Acacios a Ignacio Carrera Pinto. Jueves y Sábados"
                },
            };

            var pin020 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.373169, -70.683745),
                    Label = "Feria Cardenal Caro, Conchalí",
                    Address = "Desde Independencia a Estocolmo. Martes"
                },
            };

            var pin021 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.380336, -70.685493),
                    Label = "Feria Abraham Lincoln, Conchalí",
                    Address = "Desde El Cortijo a Quilicura. Domingos"
                },
            };

            var pin022 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.380677, -70.679314),
                    Label = "Feria Nahuelbuta, Conchalí",
                    Address = "Desde 2 Oriente a Puntiagudo. Jueves"
                },
            };

            var pin023 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.380677, -70.679314),
                    Label = "Feria El Pino, Conchalí",
                    Address = "Desde Avenida Independencia a Quilicura. Viernes"
                },
            };

            var pin024 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.388883, -70.684587),
                    Label = "Feria Barón de Juras Reales, Conchalí",
                    Address = "Desde Avenida Zapadores a El Comendador. Martes"
                },
            };

            var pin025 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.391821, -70.683213),
                    Label = "Feria Barón de Juras Reales, Conchalí",
                    Address = "Desde Avenida Zapadores a El Olivo. Sábados"
                },
            };

            var pin026 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.398951, -70.675188),
                    Label = "Feria Monterrey, Conchalí",
                    Address = "Desde Barón de Juras Reales a Fermín Vivaceta. Miércoles"
                },
            };

            var pin027 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.392609, -70.670489),
                    Label = "Feria Teniente Ponce, Conchalí",
                    Address = "Desde Sandino a La Palmilla. Miércoles"
                },
            };

            var pin028 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.392609, -70.670489),
                    Label = "Feria Alberto González, Conchalí",
                    Address = "Desde Zapadores a Ignacio Carrera Pinto. Domingos"
                },
            };

            var pin029 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.381707, -70.664808),
                    Label = "Feria Sandra, Conchalí",
                    Address = "Desde Catalina a Ignacio Alberto González. Martes"
                },
            };

            var pin030 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.384045, -70.6574),
                    Label = "Feria Guanaco, Conchalí",
                    Address = "Desde Zapadores a Ignacio Carrera Pinto. Sábados y Domingos"
                },
            };

            var pin031 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.51595, -70.594491),
                    Label = "Feria El Ulmo, La Florida",
                    Address = "Desde Lago Pirihueico a El Belloto. Viernes"
                },
            };

            var pin032 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.518924, -70.601977),
                    Label = "Feria Pudeto, La Florida",
                    Address = "Desde Cabildo a San Carlos de Ancud. Domingos"
                },
            };

            var pin033 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.528588, -70.606003),
                    Label = "Feria Aconcagua, La Florida",
                    Address = "Desde Santa Julia a Gerónimo de Alderete. Viernes"
                },
            };

            var pin034 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.530341, -70.601261),
                    Label = "Feria Los Alerces, La Florida",
                    Address = "Desde Santa Raquel a Manutara. Viernes"
                },
            };

            var pin035 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.533182, -70.608853),
                    Label = "Feria Luis de Valdivia, La Florida",
                    Address = "Desde Américo Vespucio a Punta Arenas. Miércoles y Viernes"
                },
            };

            var pin036 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.535457, -70.604292),
                    Label = "Feria Rojas Magallanes, La Florida",
                    Address = "Desde Américo Vespucio a Lircay. Domingos"
                },
            };

            var pin037 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.536914, -70.607387),
                    Label = "Feria Cautín, La Florida",
                    Address = "Desde Sótero del Río a Pasaje San Martín. Jueves"
                },
            };

            var pin038 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.53681, -70.599637),
                    Label = "Feria Chaitén, La Florida",
                    Address = "Desde Rojas Magallanes a Sótero del Río. Jueves"
                },
            };

            var pin039 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.542897, -70.599271),
                    Label = "Feria Santa Amalia, La Florida",
                    Address = "Desde Santa Raquel a Manutara. Sábados"
                },
            };

            var pin040 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.547815, -70.612489),
                    Label = "Feria Calle Uno, La Florida",
                    Address = "Desde Coronel a Punta Arenas. Viernes"
                },
            };

            var pin041 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.548727, -70.60721),
                    Label = "Feria Avenida Uno, La Florida",
                    Address = "Desde José Miguel Carrera a Trinidad. Miércoles"
                },
            };

            var pin042 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.552026, -70.612312),
                    Label = "Feria Jorge Cisterna, La Florida",
                    Address = "Desde El Carmen a Coronel. Martes"
                },
            };

            var pin043 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.559438, -70.608348),
                    Label = "Feria General Arriagada, La Florida",
                    Address = "Desde Bahía Catalina a Julio César. Sábados"
                },
            };

            var pin044 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.558187, -70.595495),
                    Label = "Feria General Arriagada, La Florida",
                    Address = "Desde Bahía Catalina a Santa Raquel. Jueves y Domingos"
                },
            };

            var pin045 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.511146, -70.5732),
                    Label = "Feria Avenida Departamental, La Florida",
                    Address = "Desde Volcán Llaima a Los Cerezos. Jueves y Domingos"
                },
            };

            var pin046 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.520181, -70.577556),
                    Label = "Feria Chacón Zamora, La Florida",
                    Address = "Desde Walker Martínez a Pasaje Los Lirquenes. Viernes"
                },
            };

            var pin047 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.528087, -70.583521),
                    Label = "Feria Gerónimo de Alderete, La Florida",
                    Address = "Desde México a Alonso de Ercilla. Martes"
                },
            };

            var pin048 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.539767, -70.578758),
                    Label = "Feria Enrique Olivares, La Florida",
                    Address = "Desde Colombia a Perú. Jueves"
                },
            };

            var pin049 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.543577, -70.576719),
                    Label = "Feria Santa Amalia, La Florida",
                    Address = "Desde Colombia a México. Miércoles"
                },
            };

            var pin050 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.549979, -70.585088),
                    Label = "Feria José Miguel Carrera, La Florida",
                    Address = "Desde Vicuña Mackena a Bacteriológico. Domingos"
                },
            };

            var pin051 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.559206, -70.581483),
                    Label = "Feria San Jorge, La Florida",
                    Address = "Desde Vicuña Mackena a Calle Diez. Sábados"
                },
            };

            var pin052 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.552626, -70.567299),
                    Label = "Feria San José de la Estrella, La Florida",
                    Address = "Desde México a La Florida. Martes"
                },
            };


            var pin053 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.555183, -70.569853),
                    Label = "Feria México, La Florida",
                    Address = "Desde San José de la Estrella a San Jorge. Jueves"
                },
            };

            var pin054 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.559617, -70.561261),
                    Label = "Feria Diego Portales, La Florida",
                    Address = "Desde Valle Hermoso a Manuel Bulnes. Miércoles"
                },
            };

            var pin055 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.541734, -70.68162),
                    Label = "Feria Los Nogales, El Bosque",
                    Address = "Desde Lo Espejo a 18 de Septiembre. Jueves y Domingos"
                },
            };

            var pin056 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.547803, -70.678583),
                    Label = "Feria Víctor Plaza Mayorga, El Bosque",
                    Address = "Desde Antonio Bórquez del Solar a Las Verónicas. Viernes"
                },
            };

            var pin057 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.549836, -70.686081),
                    Label = "Feria Luis Barros Borgoño, El Bosque",
                    Address = "Desde Rengo a Javiera Carrera. Domingo"
                },
            };

            var pin058 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.550891, -70.669845),
                    Label = "Feria Capitán Ávalos, El Bosque",
                    Address = "Desde Gran Avenida a Padre Hurtado. Miércoles y Sábados"
                },
            };

            var pin059 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.549247, -70.654216),
                    Label = "Feria Nueva Poniente, El Bosque",
                    Address = "Desde Manuel Bulnes a Tomás Yávar. Miércoles y Sábados"
                },
            };

            var pin060 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.556238, -70.661391),
                    Label = "Feria Avenida Julio Covarrubias, El Bosque",
                    Address = "Desde Los Aviadores a Jorge Luco. Martes y Viernes"
                },
            };

            var pin061 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.560905, -70.666391),
                    Label = "Feria Observatorio, El Bosque",
                    Address = "Desde Los Mimbres a Padre Hurtado. Miércoles y Sábados"
                },
            };

            var pin062 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.572571, -70.678369),
                    Label = "Feria Los Carolinos, El Bosque",
                    Address = "Desde Los Álamos a Padre Hurtado. Martes y Sábados"
                },
            };

            var pin063 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.563757, -70.66689),
                    Label = "Feria Los Sauces, El Bosque",
                    Address = "Desde Los Paltos a Los Boldos. Jueves y Domingos"
                },
            };

            var pin064 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.575315, -70.666836),
                    Label = "Feria Las Canteras, El Bosque",
                    Address = "Desde Zinc a La Pampa. Martes y Viernes"
                },
            };

            var pin065 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.577398, -70.677125),
                    Label = "Feria Camino del Inca, El Bosque",
                    Address = "Desde Padre Hurtado a Lolol. Jueves y Domingos"
                },
            };

            var pin066 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.581286, -70.67441),
                    Label = "Feria Las Parcelas, El Bosque",
                    Address = "Desde Padre Hurtado a Peñablanca. Jueves y Domingos"
                },
            };

            var pin067 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.581447, -70.665388),
                    Label = "Feria Vecinal Sur, El Bosque",
                    Address = "Desde San Francisco a Océano Atlántico. Miércoles y Sábados"
                },
            };

            var pin068 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.549729, -70.68669),
                    Label = "Feria Luis Barros Borgoño, El Bosque",
                    Address = "Desde Rengo a	Indio Jerónimo. Miércoles"
                },
            };

            var pin069 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.51489, -70.616343),
                    Label = "Feria Sebastopol, La Granja",
                    Address = "Desde La Castrina a Manio. Miércoles y Sábados"
                },
            };

            var pin070 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.535949, -70.632954),
                    Label = "Feria Presidente Eisenhower, La Granja",
                    Address = "Desde Santa Rosa a Isla Negra. Martes y Viernes"
                },
            };

            var pin071 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.545267, -70.613235),
                    Label = "Feria Tricolor, La Granja",
                    Address = "Desde Coronel a Isla Morelos. Jueves y Domingo"
                },
            };

            var pin072 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.524456, -70.61354),
                    Label = "Feria Osorno, La Granja",
                    Address = "Desde Coronel a Punta Arenas. Martes y Viernes"
                },
            };

            var pin073 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.546849, -70.627402),
                    Label = "Feria Vicuña Mackenna, La Granja",
                    Address = "Desde Sofía Eastman de Huneeus a Joaquín Edwards Bello. Martes y Viernes"
                },
            };

            var pin074 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.522542, -70.619554),
                    Label = "Feria Manio, La Granja",
                    Address = "Desde Yungay a Padre Esteban Gumucio. Martes y Viernes"
                },
            };

            var pin075 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.53898, -70.627354),
                    Label = "Feria 8 Poniente, La Granja",
                    Address = "Desde San Gregorio a Sur. Miércoles y Sábados"
                },
            };

            var pin076 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.529375, -70.619441),
                    Label = "Feria Combarbalá, La Granja",
                    Address = "Desde Coronel a Quilpué. Miércoles y Sábados"
                },
            };

            var pin077 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.533418, -70.619377),
                    Label = "Feria Valdivia, La Granja",
                    Address = "Desde Coronel a Cardenal Raúl Silva Henríquez. Jueves y Domingo"
                },
            };

            var pin078 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.551052, -70.628754),
                    Label = "Feria Canto General, La Granja",
                    Address = "Desde Santa Rosa a Joaquín Edwards Bello. Jueves y Domingo"
                },
            };

            var pin079 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.520422, -70.629199),
                    Label = "Feria Padre Esteban Gumucio, La Granja",
                    Address = "Desde Los Vilos a Cardenal Raúl Silva Henríquez. Miércoles y Sábados"
                },
            };

            var pin080 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.556019, -70.614348),
                    Label = "Feria Santo Tomás, La Granja",
                    Address = "Desde Acceso Sur a Bahía Catalina. Miércoles y Sábados"
                },
            };

            var pin081 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.518329, -70.621238),
                    Label = "Feria Presidente  Lula da Silva, La Granja",
                    Address = "Desde 19 Oriente a Calle N. Jueves y Domingo"
                },
            };


            var pin082 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.450358, -70.704859),
                    Label = "Feria Santa Petronila, Estación Central",
                    Address = "Desde Embajador Quintana a Porto Seguro. Jueves y Domingo"
                },
            };

            var pin083 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.459489, -70.709003),
                    Label = "Feria Las Violetas, Estación Central",
                    Address = "Desde El Boldo a Las Catalpas. Martes y Viernes"
                },
            };

            var pin084 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.457009, -70.696375),
                    Label = "Feria Manuel Thompson, Estación Central",
                    Address = "Desde Amengual a Recreo. Jueves y Domingo"
                },
            };

            var pin085 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.461655, -70.691673),
                    Label = "Feria Santa Teresa, Estación Central",
                    Address = "Desde 5 de Abril a Tololo. Martes y Viernes"
                },
            };

            var pin086 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.469844, -70.689999),
                    Label = "Feria Antártica, Estación Central",
                    Address = "Desde General Velásquez a Santa Teresa (Pingüino). Jueves y Domingos"
                },
            };

            var pin087 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.475357, -70.69443),
                    Label = "Feria Luis Cruz Martínez, Estación Central",
                    Address = "Desde Padre Vicente Irarrázaval a Uspallata. Martes y Viernes"
                },
            };

            var pin088 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.465674, -70.701302),
                    Label = "Feria San José, Estación Central",
                    Address = "Desde Juana Weber de Amunátegui a 5 de Abril. Miércoles y Sábados"
                },
            };

            var pin089 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.467231, -70.71326),
                    Label = "Feria Rivas Vicuña, Estación Central",
                    Address = "Desde Torslanda a 5 de Abril. Martes y Viernes"
                },
            };

            var pin090 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.470363, -70.711232),
                    Label = "Feria Taitao, Estación Central",
                    Address = "Desde Aeropuerto a Lemuy. Miércoles y Sábados"
                },
            };

            var pin091 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.474462,-70.711446),
                    Label = "Feria Quemchi, Estación Central",
                    Address = "Desde Las Estepas a Palena. Jueves y Domingos"
                },
            };

            var pin092 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.470784, -70.722647),
                    Label = "Feria Curacaví, Estación Central",
                    Address = "Desde 5 de Abril a Las Parcelas. Martes y Viernes"
                },
            };

            var pin093 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.376842, -70.643452),
                    Label = "Feria Joaquín Aguirre, Huechuraba",
                    Address = "Desde Elías Lafferte a Río Cachapoal. Martes"
                },
            };

            var pin094 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.378571, -706326),
                    Label = "Feria Salvador Allende, Huechuraba",
                    Address = "Desde Estados Unidos a Noruega. Domingos"
                },
            };

            var pin095 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.365983, -70.631307),
                    Label = "Feria Pablo Neruda, Huechuraba",
                    Address = "Desde del Pincoy a Jacaranda. Miércoles y Sábados"
                },
            };

            var pin096 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.40737, -70.67573),
                    Label = "Feria Las Cañas, Independencia",
                    Address = "Desde Nueva de Matte a Nueva Uno. Miércoles y Sábados"
                },
            };

            var pin097 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.40487, -70.67573),
                    Label = "Feria Guanaco, Independencia",
                    Address = "Desde Einstein a Avenida México. Jueves y Domingos"
                },
            };

            var pin098 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.412171, -70.665634),
                    Label = "Feria Cronista Góngora, Independencia",
                    Address = "Desde Padre Faustino Gazziero a Julieta. Miércoles y Sábados"
                },
            };

            var pin099 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.416613, -70.658821),
                    Label = "Feria Maruri, Independencia",
                    Address = "Desde Domingo Santa María a Bezanilla. Martes y Viernes"
                },
            };

            var pin100 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.419926, -70.67352),
                    Label = "Feria Enrique Soro, Independencia",
                    Address = "Desde Salomón Sack a Panamericana Norte. Martes y Viernes"
                },
            };

            var pin101 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.423472, -70.666155),
                    Label = "Feria El Pino, Independencia",
                    Address = "Desde Salomón Sack a Los Ángeles. Miércoles y Sábados"
                },
            };

            var pin102 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.422971, -70.660554),
                    Label = "Feria Colón, Independencia",
                    Address = "Desde Fermín Vivaceta a López de Alcázar. Jueves y Domingos"
                },
            };

            var pin103 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.417329, -70.676245),
                    Label = "Feria Germán Domínguez, Independencia",
                    Address = "Desde Longitudinal 4 a Eduardo Frei. Domingos"
                },
            };



            var pin170 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.514707, -70.778893),
                    Label = "Feria 3 Poniente, Maipú",
                    Address = "Desde Av. Portales a Camino a Rinconada. Miércoles y Sábados",

                },

            };

            var pin104 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.519787, -70.667399),
                    Label = "Feria Lucerna, La Cisterna",
                    Address = "Desde Colón a San Luis. Jueves y Domingos"
                },
            };

            var pin105 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.529286, -70.675033),
                    Label = "Feria Brisas del Maipo, La Cisterna",
                    Address = "Desde Industria a Letras. Martes y Viernes"
                },
            };

            var pin106 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.53712, -70.679528),
                    Label = "Feria Inés Rivas, La Cisterna",
                    Address = "Desde Manuel Ballesteros a Manuel Rengifo. Jueves y Domingos"
                },
            };

            var pin107 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.518001, -70.651827),
                    Label = "Feria Fuenzalida Urrejola, La Cisterna",
                    Address = "Desde Angamos a Iquique. Jueves y Domingos"
                },
            };

            var pin108 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.53314,-70.655227),
                    Label = "Feria Alejandro Vial, La Cisterna",
                    Address = "Desde Uruguay a Las Brisas. Miércoles y Sábados"
                },
            };

            var pin109  = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.542378, -70.653945),
                    Label = "Feria Goycolea, La Cisterna",
                    Address = "Desde Pero a San Pedro. Martes y Viernes"
                },
            };

            var pin110 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.546214, -70.65335),
                    Label = "Feria Nueva Poniente, La Cisterna",
                    Address = "Desde Vicuña Mackenna a Torreblanca. Miércoles y Sábados"
                },
            };

            var pin111 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.556063, -70.614085),
                    Label = "Feria Santo Tomás, La Pintana",
                    Address = "Desde La Serena a Bahía Catalina. Martes y Viernes"
                },
            };

            var pin112 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.560538, -70.618608),
                    Label = "Feria Las Parcelas, La Pintana",
                    Address = "Desde General Arriagada a Edith Madge de Huneeus. Miércoles y Sábados"
                },
            };

            var pin113 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.560118, -70.623191),
                    Label = "Feria Joaquín Edwards Bello, La Pintana",
                    Address = "Desde Santo Tomás a Pablo VI. Jueves"
                },
            };

            var pin114  = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.560118, -70.623191),
                    Label = "Feria José Edwards Bello, La Pintana",
                    Address = "Desde Santo Tomás a Pablo VI. Miércoles y Sábados"
                },
            };

            var pin115 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.558662, -70.635708),
                    Label = "Feria Del Sembrador, La Pintana",
                    Address = "Desde Pedro Aguirre Cerda a El Bosque. Jueves y Domingos"
                },
            };

            var pin116 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.562746, -70.63841),
                    Label = "Feria Pedro Aguirre Cerda, La Pintana",
                    Address = "Desde Observatorio a Violeta Parra. Martes y Viernes"
                },
            };

            var pin117 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.561924, -70.646564),
                    Label = "Feria Almirante Latorre, La Pintana",
                    Address = "Desde Observatorio a Violeta Parra. Miércoles y Sábados"
                },
            };

            var pin118 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.561173, -70.651842),
                    Label = "Feria Las Aguilas, La Pintana",
                    Address = "Desde Antonio Machado a Violeta Parra. Martes y Viernes"
                },
            };

            var pin119 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.582806, -70.659417),
                    Label = "Feria Julio Barrenechea, La Pintana",
                    Address = "Desde San Francisco a Julio Chavez. Jueves"
                },
            };

            var pin120 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.583378, -70.655061),
                    Label = "Feria Bernardino Parada, La Pintana",
                    Address = "Desde José Toribio Medina a Julio Chavez. Martes y Viernes"
                },
            };

            var pin121 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.581018, -70.648066),
                    Label = "Feria John Kennedy, La Pintana",
                    Address = "Desde Bernardino Parada a Julio Barrenechea. Miércoles y Sábados"
                },
            };

            var pin122 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.58086, -70.636349),
                    Label = "Feria Muñoz Gamero, La Pintana",
                    Address = "Desde Porto Alegre a Patagonia. Martes y Viernes"
                },
            };

            var pin123 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.59194, -70.618798),
                    Label = "Feria Juanita, La Pintana",
                    Address = "Desde El Ombú a Batallón Chacabuco. Jueves y Domingos"
                },
            };

            var pin124 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.594639, -70.618588),
                    Label = "Feria El Ombú, La Pintana",
                    Address = "Desde El Haulle a Sexto de Línea. Miércoles y Sábados"
                },
            };

            var pin125 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.591332, -70.612746),
                    Label = "Feria El Fundador, La Pintana",
                    Address = "Desde El Ombú a Batallón Chacabuco. Martes y Viernes"
                },
            };

            var pin126 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.55715, -70.652701),
                    Label = "Feria Vicente Llanos, La Pintana",
                    Address = "Desde San Francisco a Gala. Jueves y Domingos"
                },
            };

            var pin127 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.439786, -70.571698),
                    Label = "Feria Tobalaba, La Reina",
                    Address = "Desde Principe de Gales a Tobalaba. Miércoles y Sábados"
                },
            };

            var pin128 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.430143, -70.549913),
                    Label = "Feria Bilbao, La Reina",
                    Address = "Desde Florencio Barrios a Curaco. Martes y Sábados"
                },
            };

            var pin129 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.456222, -70.53908),
                    Label = "Feria Quinchamalí, La Reina",
                    Address = "Desde Melinka a Chapilca. Domingos"
                },
            };

            var pin130 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.451647, -70.558493),
                    Label = "Feria Clorinda Henríquez, La Reina",
                    Address = "Desde Larraín a Loreley. Domingos"
                },
            };

            var pin131 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.40171, -70.568152),
                    Label = "Feria Presidente Riesco, Las Condes",
                    Address = "Desde Manquehue norte a Estocolmo. Miércoles"
                },
            };

            var pin132 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.407881, -70.54442),
                    Label = "Feria Apoquindo, Las Condes",
                    Address = "Desde Apoquindo a Camino el Alba. Sábados"
                },
            };

            var pin133 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.424959, -70.564),
                    Label = "Feria Isabel la Católica, Las Condes",
                    Address = "Desde Manquehue sur a Manquehue sur. Miércoles y Domingos"
                },
            };

            var pin134 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.42066, -70.533788),
                    Label = "Feria Patricia, Las Condes",
                    Address = "Desde Paul Harris a Los Vilos. Domingos"
                },
            };

            var pin135 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.36075, -70.509149),
                    Label = "Feria Alfredo Arteaga, Lo Barnechea",
                    Address = "Desde Raúl Labbé a Cuatro Vientos. Domingos"
                },
            };

            var pin136 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.35851, -70.503748),
                    Label = "Feria El Esfuerzo, Lo Barnechea",
                    Address = "Desde Uno norte a Los Quincheros. Sábados"
                },
            };

            var pin137 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.528293, -70.698293),
                    Label = "Feria Pablo Neruda, Lo Espejo",
                    Address = "Desde 9 de Enero a Balmaceda. Jueves y Domingos"
                },
            };

            var pin138 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.532371, -70.692896),
                    Label = "Feria Balmaceda, Lo Espejo",
                    Address = "Desde Astaburuaga a La Sierra. Martes y Viernes"
                },
            };

            var pin139 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.524376, -70.690354),
                    Label = "Feria Júpiter, Lo Espejo",
                    Address = "Desde Eduardo Frei Montalva a Venus. Martes y Viernes"
                },
            };

            var pin140 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.519823, -70.698346),
                    Label = "Feria La Habana, Lo Espejo",
                    Address = "Desde Eduardo Frei Montalva a Vespucio Sur. Miércoles y Sábados"
                },
            };

            var pin141 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.521692, -70.681717),
                    Label = "Feria Adolfo López Mateo, Lo Espejo",
                    Address = "Desde Acapulco a Durango. Miércoles y Sábados"
                },
            };

            var pin142 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.513794, -70.693492),
                    Label = "Feria Salvador Allende, Lo Espejo",
                    Address = "Desde Seis poniente a Del Ferrocarril. Jueves y Domingos"
                },
            };

            var pin143 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.506119, -70.688127),
                    Label = "Feria Cooperación, Lo Espejo",
                    Address = "Desde Lo Ovalle a Buenaventura. Miércoles y Sábados"
                },
            };

            var pin144 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.511522, -70.675639),
                    Label = "Feria Valparaíso, Lo Espejo",
                    Address = "Desde Lo Ovalle a Lincoln. Martes y Viernes"
                },
            };

            var pin145 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.515834, -70.68978),
                    Label = "Feria Monterrey, Lo Espejo",
                    Address = "Desde 19 sur a Salvador Allende. Jueves y Domingos"
                },
            };

            var pin146 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.51476, -70.686861),
                    Label = "Feria Santa Anita, Lo Espejo",
                    Address = "Desde Acapulco a Salvador Allende. Jueves y Domingos"
                },
            };

            var pin147 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.448308, -70.737051),
                    Label = "Feria Gabriela Mistral, Lo Prado",
                    Address = "Desde Paula Jaraquemada a Eduardo Llanos. Jueves y Domingos"
                },
            };

            var pin148 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.451603, -70.731059),
                    Label = "Feria Las Torres, Lo Prado",
                    Address = "Desde Dorsal a Milton Rossel. Martes y Viernes"
                },
            };

            var pin149 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.441165, -70.730957),
                    Label = "Feria Las Torres, Lo Prado",
                    Address = "Desde San Pablo a Los Copihues. Miércoles y Sábados"
                },
            };

            var pin150 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.449096, -70.722481),
                    Label = "Feria Neptuno, Lo Prado",
                    Address = "Desde Isla Walton a Dorsal. Martes y Viernes"
                },
            };

            var pin151 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.448112, -70.715014),
                    Label = "Feria Santa Marta, Lo Prado",
                    Address = "Desde Dorsal a Portales. Miércoles y Domingos"
                },
            };

            var pin152 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.452856, -70.71297),
                    Label = "Feria Isla Decepción, Lo Prado",
                    Address = "Desde Ovalle a Pedro de Córdova. miercoles y Sábados"
                },
            };

            var pin153 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.506249, -70.608914),
                    Label = "Feria Ortíz de Zárate, Macul",
                    Address = "Desde Marathon a Jorge Quevedo. Viernes"
                },
            };

            var pin154 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.50556, -70.592579),
                    Label = "Feria Las Codornices, Macul",
                    Address = "Desde Missouri a Los Milanos. Jueves y Domingos"
                },
            };

            var pin155 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.499821, -70.592764),
                    Label = "Feria El Líbano, Macul",
                    Address = "Desde Amador Neghme a Armando Pisantes. Jueves"
                },
            };

            var pin156 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.489621, -70.6047),
                    Label = "Feria Obispo Arturo Espinoza, Macul",
                    Address = "Desde Escuela Agrícola a Coipué. Miércoles"
                },
            };

            var pin157 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.483509, -70.609093),
                    Label = "Feria Castillo Urizar, Macul",
                    Address = "Desde Quilín a Los Plátanos. Domingos"
                },
            };

            var pin158 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.488046, -70.584194),
                    Label = "Feria Quilín, Macul",
                    Address = "Desde Los Evangelistas a Los Profetas. Martes y Sábados"
                },
            };

            var pin159 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.483536, -70.585318),
                    Label = "Feria Los Plátanos, Macul",
                    Address = "Desde Ramón Cruz a Siria. Jueves y Domingos"
                },
            };

            var pin160 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.475438, -70.59226),
                    Label = "Feria Santa Julia, Macul",
                    Address = "Desde Rodrigo de Araya a Los Espinos. Sábados"
                },
            };

            var pin161 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.474574, -70.581743),
                    Label = "Feria Ramón Cruz, Macul",
                    Address = "Desde Mercedes Marín del Solar a Aurelio Huerta. Martes y Viernes"
                },
            };

            var pin162 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.555004, -70.796762),
                    Label = "Feria Caletera Camino a Melipilla, Maipú",
                    Address = "Desde Parque Central Poniente a El Esfuerzo. Jueves y Domingos"
                },
            };

            var pin163 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.538211, -70.789558),
                    Label = "Feria Gabriel González Videla, Maipú",
                    Address = "Desde 4 poniente a Caleta Camarones. Miércoles y Sábados"
                },
            };

            var pin164 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.538873, -70.774924),
                    Label = "Feria Ferrocarril, Maipú",
                    Address = "Desde Domingo Faustino Sarmiento a Cerro Barón. Jueves y Domingos"
                },
            };

            var pin165 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.544399, -70.773255),
                    Label = "Feria Las Industrias, Maipú",
                    Address = "Desde 4 poniente a Etiopia. Jueves y Domingos"
                },
            };

            var pin166 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.540563, -70.77097),
                    Label = "Feria Jorge Guerra, Maipú",
                    Address = "Desde Judea a Jacques Cousteau. Martes y Viernes"
                },
            };

            var pin167 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.530887, -70.769801),
                    Label = "Feria Hermógenes Pérez de Arce, Maipú",
                    Address = "Desde Silva Carvallo a Andrés Amenabar Vergara. Miércoles y Sábados"
                },
            };

            var pin168 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.518732, -70.748938),
                    Label = "Feria Santa María, Maipú",
                    Address = "Desde Vicente Reyes a Segunda Transversal. Martes y Viernes"
                },
            };

            var pin169 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.514546, -70.767891),
                    Label = "Feria Huáscar, Maipú",
                    Address = "Desde Padre Hurtado a San José. Martes y Viernes"
                },
            };

            var pin171 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.514063, -70.785234),
                    Label = "Feria Las Naciones, Maipú",
                    Address = "Desde Av. Portales a Camino a Rinconada. Jueves y Domingo",
                },

            };

            var pin172 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.512417, -70.792149),
                    Label = "Feria Inca de Oro, Maipú",
                    Address = "Desde 4 poniente a La Galaxia. Jueves y Domingos"
                },
            };

            var pin173 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.512533, -70.793619),
                    Label = "Feria Inca de Oro, Maipú",
                    Address = "Desde La Galaxia a 4 poniente. Miércoles y Sábados"
                },
            };

            var pin174 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.506414, -70.794541),
                    Label = "Feria Camino a Rinconada, Maipú",
                    Address = "Desde La Galaxia a Roberto Durán. Miércoles y Sábados"
                },
            };

            var pin175 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.509026, -70.787525),
                    Label = "Feria Borgoño, Maipú",
                    Address = "Desde Las Naciones a 4 poniente. Martes y Viernes"
                },
            };

            var pin176 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.513955, -70.777906),
                    Label = "Feria 3 poniente, Maipú",
                    Address = "Desde Diego Barros Ortíz a Camino a Rinconada. Jueves y Domingos"
                },
            };

            var pin177 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.502657, -70.77347),
                    Label = "Feria O'higgins, Maipú",
                    Address = "Desde Guayaquil a El Olimpo. Martes y Viernes"
                },
            };

            var pin178 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.490936, -70.766314),
                    Label = "Feria Teatro Princesa, Maipú",
                    Address = "Desde Teatro Municipal a Teatro Ópera. Jueves y Domingos"
                },
            };

            var pin179 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.487402, -70.76272),
                    Label = "Feria Jorge Alessandri, Maipú",
                    Address = "Desde La Sinfonía a La Reforma. Martes y Viernes"
                },
            };

            var pin180 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.492985, -70.735914),
                    Label = "Feria Lumen, Maipú",
                    Address = "Desde 3 norte a Alaska. Miércoles y Sábados"
                },
            };

            var pin181 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.483268, -70.741042),
                    Label = "Feria Isabel Riquelme, Maipú",
                    Address = "Desde Santa Rosa a Via Appia. Martes y Viernes"
                },
            };

            var pin182 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.470063, -70.749118),
                    Label = "Feria Avenida El Descanso, Maipú",
                    Address = "Desde Gustavo Eiffel a Longitudinal. Miércoles y Sábados"
                },
            };

            var pin183 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.475664, -70.733598),
                    Label = "Feria Las Parcelas, Maipú",
                    Address = "Desde Santa Corina a Reino Unido. Jueves y Domingos"
                },
            };

            var pin184 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.517855, -70.79688),
                    Label = "Feria El Conquistador, Maipú",
                    Address = "Desde Las Tinajas a Portales. Martes y Viernes"
                },
            };

            var pin185 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.520449, -70.793549),
                    Label = "Feria Campanario, Maipú",
                    Address = "Desde La Dormida a 4 poniente. Jueves y Domingos"
                },
            };

            var pin186 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.454217, -70.623663),
                    Label = "Feria Matta Oriente, Ñuñoa",
                    Address = "Desde Irarrázaval a Lo Encalada. Miércoles y Sábados"
                },
            };

            var pin187 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.468913, -70.623003),
                    Label = "Feria San Eugenio, Ñuñoa",
                    Address = "Desde Carlos Dittborn a Guillermo Mann. Sábados"
                },
            };

            var pin188 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.467911, -70.615638),
                    Label = "Feria Nueva dos, Ñuñoa",
                    Address = "Desde Marathon a Francisco Meneses. Jueves y Domingos"
                },
            };

            var pin189 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.470292, -70.607312),
                    Label = "Feria Guillermo Mann, Ñuñoa",
                    Address = "Desde Pedro de Valdivia a Nelson. Martes y Viernes"
                },
            };

            var pin190 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.461485, -70.604893),
                    Label = "Feria Juan Gómez Milla, Ñuñoa",
                    Address = "Desde Pedro de Valdivia a Los 3 Antonios. Sábados"
                },
            };

            var pin191 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.470149, -70.591503),
                    Label = "Feria Ignacio Carrera Pinto, Ñuñoa",
                    Address = "Desde Juan Moya a Premio Nobel. Miércoles"
                },
            };

            var pin192 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.465423, -70.578457),
                    Label = "Feria María Celeste, Ñuñoa",
                    Address = "Desde Américo Vespucio a Ramón Cruz. Viernes y Domingos"
                },
            };

            var pin193 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.458656, -70.582427),
                    Label = "Feria Duble Almeyda, Ñuñoa",
                    Address = "Desde Ramón Cruz a Jorge Mockenberg. Viernes"
                },
            };

            var pin194 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.449266, -70.583666),
                    Label = "Feria Ortúzar, Ñuñoa",
                    Address = "Desde Las Verónicas a Simón Bolivar. Domingos"
                },
            };

            var pin195 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.44206, -70.580217),
                    Label = "Feria Emilia Tellez, Ñuñoa",
                    Address = "Desde Coventry a Bremen. Miércoles y Sábados"
                },
            };

            var pin196 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.504115, -70.674866),
                    Label = "Feria Manuela Errázuriz, Pedro Aguirre Cerda",
                    Address = "Desde Melinka a Pirihueico. Miércoles y Sábados"
                },
            };

            var pin197 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.494873, -70.680172),
                    Label = "Feria Paseo Grohnert, Pedro Aguirre Cerda",
                    Address = "Desde Departamental a Bombero Ossandón. Jueves y Domingos"
                },
            };

            var pin198 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.493093, -70.67249),
                    Label = "Feria Félix Mendelssohn, Pedro Aguirre Cerda",
                    Address = "Desde Lazo a La Marina. Miércoles y Sábados"
                },
            };

            var pin199 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.488481, -70.676647),
                    Label = "Feria Galo González, Pedro Aguirre Cerda",
                    Address = "Desde 30 de Octubre a Ramona Parra. Miércoles y Sábados"
                },
            };

            var pin200 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.484163, -70.676363),
                    Label = "Feria 2 de Abril, Pedro Aguirre Cerda",
                    Address = "Desde Galo González a 1 de mayo. Martes y Viernes"
                },
            };

            var pin201 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.483187, -70.662523),
                    Label = "Feria Enrique Matte, Pedro Aguirre Cerda",
                    Address = "Desde Club Hípico a Manuela Errázuriz. Miércoles y Sábados"
                },
            };

            var pin202 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.501574, -70.685982),
                    Label = "Feria Cooperación, Pedro Aguirre Cerda",
                    Address = "Desde Buenaventura a Lo Ovalle. Miércoles y Sábados"
                },
            };

            var pin203 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.49396, -70.6853),
                    Label = "Feria Centroamérica, Pedro Aguirre Cerda",
                    Address = "Desde Avenida Central a Haití. Jueves y Domingos"
                },
            };

            var pin204 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.503963, -70.584878),
                    Label = "Feria Horacio Toro, Peñalolén",
                    Address = "Desde San Luis a Los Salecianos. Martes y Viernes"
                },
            };

            var pin205 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.511236, -70.567911),
                    Label = "Feria Departamental, Peñalolén",
                    Address = "Desde Los Clarines a Los Cerezos. Jueves y Domingos"
                },
            };

            var pin206 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.507667, -70.568141),
                    Label = "Feria San Luis de Macul, Peñalolén",
                    Address = "Desde Los Talladores a Tucapel. Miércoles"
                },
            };

            var pin207 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.503346, -70.570716),
                    Label = "Feria Las Torres, Peñalolén",
                    Address = "Desde 465 a Pasaje Dos. Sábados"
                },
            };

            var pin208 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.47227, -70.531459),
                    Label = "Feria Las Perdices, Peñalolén",
                    Address = "Desde Los Baqueanos a Las Penas. Martes y Sábados"
                },
            };

            var pin209 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.482006, -70.567101),
                    Label = "Feria Caracas, Peñalolén",
                    Address = "Desde Los Presidentes a Bolivar. Miércoles y Sábados"
                },
            };

            var pin210 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.477183, -70.568463),
                    Label = "Feria El Valle, Peñalolén",
                    Address = "Desde Desembocadura a Pasaje 42. Jueves y Domingos"
                },
            };

            var pin211 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.475303, -70.573071),
                    Label = "Feria Frontera, Peñalolén",
                    Address = "Desde El Valle a El Litoral. Martes y Viernes"
                },
            };

            var pin212 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.469236, -70.568131),
                    Label = "Feria Los Molineros, Peñalolén",
                    Address = "Desde Grecia a Laura Rodríguez. Miércoles y Sábados"
                },
            };

            var pin213 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.469701, -70.561994),
                    Label = "Feria Ictinos, Peñalolén",
                    Address = "Desde Grecia a Los Orientales. Sábados"
                },
            };

            var pin214 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.462595, -70.553952),
                    Label = "Feria José Arrieta, Peñalolén",
                    Address = "Desde Diego Rojas a Tobalaba. Jueves y Domingos"
                },
            };

            var pin215 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.472842, -70.541974),
                    Label = "Feria Avenida Consistorial, Peñalolén",
                    Address = "Desde Tagua Tagua a Las Parcelas. Miércoles y Domingos"
                },
            };

            var pin216 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.430331, -70.625498),
                    Label = "Feria Santa María, Providencia",
                    Address = "Desde Calle del Arzobispo a Los Piñones. Domingos",

                },

            };

            var pin217 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.446464, -70.615359),
                    Label = "Feria Santa Isabel, Providencia",
                    Address = "Desde Caupolicán a Obispo Manuel de Alday. Sábados",

                },

            };

            var pin218 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.441711, -70.593054),
                    Label = "Feria Los Concilios, Providencia",
                    Address = "Desde Renato Zanelli a Los Pedro Navia. Viernes",

                },

            };

            var pin219 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.462988, -70.752919),
                    Label = "Feria La Estrella, Pudahuel",
                    Address = "Desde Laguna Sur a Los Mares. Jueves y Domingos"
                },
            };

            var pin220 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.454754, -70.757092),
                    Label = "Feria La Travesía, Pudahuel",
                    Address = "Desde Oceanáa a Isla grande de Tierra del Fuego. Martes y Viernes"
                },
            };

            var pin221 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.448192, -70.755993),
                    Label = "Feria Faldas del Morro, Pudahuel",
                    Address = "Desde La Estrella a Osa Mayor. Jueves y Domingos"
                },
            };

            var pin222 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.433411, -70.758337),
                    Label = "Feria Santa Victoria, Pudahuel",
                    Address = "Desde San Pablo a San Francisco. Martes y Viernes"
                },
            };

            var pin223 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.432552, -70.766308),
                    Label = "Feria Serrano, Pudahuel",
                    Address = "Desde San Daniel a Yungay. Jueves y Domingos"
                },
            };

            var pin224 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.457708, -70.741321),
                    Label = "Feria La Travesía, Pudahuel",
                    Address = "Desde Teniente Cruz a Mar de Drake. Miércoles y Sábados"
                },
            };

            var pin225 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.44761, -70.747565),
                    Label = "Feria Coronoa Sueca, Pudahuel",
                    Address = "Desde Los Ediles a El Salitre. Miércoles y Sábados"
                },
            };

            var pin226 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.439589, -70.740741),
                    Label = "Feria Teniente Cruz, Pudahuel",
                    Address = "Desde Ricardo Vial a San Francisco. Martes y Viernes"
                },
            };

            var pin227 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.429955, -70.74587),
                    Label = "Feria José Joaquín Pérez, Pudahuel",
                    Address = "Desde La Estrella a Teniente Cruz. Miércoles y Sábados"
                },
            };

            var pin228 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.631442, -70.61964),
                    Label = "Feria Reloj de Sol, Puente Alto",
                    Address = "Desde Raíz de Sueño a Aguas Abajo. Sábados  "
                },
            };

            var pin229 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.627583, -70.624543),
                    Label = "Feria Quitalmahue, Puente Alto",
                    Address = "Desde Curaco de Velez a San Pedro. Jueves y Domingos"
                },
            };

            var pin230 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.615138, -70.625594),
                    Label = "Feria Río Colorado, Puente Alto",
                    Address = "Desde Estero Leonoera a Avenida Santa Rosa. Domingos  "
                },
            };

            var pin231 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.614891, -70.619),
                    Label = "Feria Río Queltehues, Puente Alto",
                    Address = "Desde Estero Machalí a Río Volcán. Viernes  "
                },
            };

            var pin232 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.62057, -70.608734),
                    Label = "Feria Sargento Menadier, Puente Alto",
                    Address = "Desde Juanita a Osa Mayor. Miércoles y Sábados"
                },
            };

            var pin233 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.625126, -70.593944),
                    Label = "Feria Nocedal, Puente Alto",
                    Address = "Desde San Pedro a El Tronco. Martes y Viernes"
                },
            };

            var pin234 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.619265, -70.590527),
                    Label = "Feria Éjercito Libertador, Puente Alto",
                    Address = "Desde Arturo Prat a Real Audiencia. Jueves  "
                },
            };

            var pin235 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.617559, -70.577872),
                    Label = "Feria Tocornal Grez, Puente Alto",
                    Address = "Desde Abate Molina a Sargento Menadier. Martes  "
                },
            };

            var pin236 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.61562, -70.587094),
                    Label = "Feria Arturo Prat, Puente Alto",
                    Address = "Desde Argentina a Éjercito Libertador. Domingos  "
                },
            };

            var pin237 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.621686, -70.580737),
                    Label = "Feria Uruguay, Puente Alto",
                    Address = "Desde San Pedro a Presidente Salvador Allende. Viernes  "
                },
            };

            var pin238 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.605327, -70.571419),
                    Label = "Feria Eduardo Cordero, Puente Alto",
                    Address = "Desde Santa Elena a Ignacio Domeyko. Miércoles  "
                },
            };

            var pin239 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.608794, -70.5732),
                    Label = "Feria Santa Elena, Puente Alto",
                    Address = "Desde Eyzaguirre a Irarrázaval. Sábados  "
                },
            };

            var pin240 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(33.61587, -70.565819),
                    Label = "Feria Avenida Laja, Puente Alto",
                    Address = "Desde Circunvalación a Puntilla. Martes  "
                },
            };

            var pin241 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.612868, -70.555095),
                    Label = "Feria Tomé, Puente Alto",
                    Address = "Desde Los Loros a Maitahue. Domingos  "
                },
            };

            var pin242 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.6105, -70.550492),
                    Label = "Feria Pie Andino, Puente Alto",
                    Address = "Desde Eyzaguirre a Luis Carrasco. Jueves  "
                },
            };

            var pin243 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.609955, -70.522496),
                    Label = "Feria El Volcán, Puente Alto",
                    Address = "Desde El Llano a Los Pinos. Miércoles  "
                },
            };

            var pin244 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.597731, -70.558931),
                    Label = "Feria Tomé, Puente Alto",
                    Address = "Desde San Carlos a Caleta Brava. Martes  "
                },
            };

            var pin245 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.596784, -70.562643),
                    Label = "Feria San Carlos, Puente Alto",
                    Address = "Desde Nonato Coo a Cerro Castillo. Domingos  "
                },
            };

            var pin246 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.593978, -70.576226),
                    Label = "Feria Las Nieves oriente, Puente Alto",
                    Address = "Desde Concha y Toro a Los Mallines. Domingos  "
                },
            };

            var pin247 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.592637, -70.573393),
                    Label = "Feria Nemecio Vicuña, Puente Alto",
                    Address = "Desde Las Nieves oriente a San Hugo. Jueves  "
                },
            };

            var pin248 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.588508, -70.566403),
                    Label = "Feria Ángel Pimentel, Puente Alto",
                    Address = "Desde Nonato Coo a San Renpe. Martes  "
                },
            };

            var pin249 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.580133, -70.572873),
                    Label = "Feria El Peñón, Puente Alto",
                    Address = "Desde Valle Central a Troncal San Francisco. Miércoles y Sábados"
                },
            };

            var pin250 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.583512, -70.566189),
                    Label = "Feria Troncal San Francisco, Puente Alto",
                    Address = "Desde Santa Soledad a Nonato Coo. Jueves  "
                },
            };

            var pin251 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.582377, -70.558158),
                    Label = "Feria Las Nieves, Puente Alto",
                    Address = "Desde El Peñón a Luis Matte Larraín. Domingos  "
                },
            };

            var pin252 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.58336, -70.553837),
                    Label = "Feria Punta Blanca, Puente Alto",
                    Address = "Desde Buin a El Barquito. Viernes  "
                },
            };

            var pin253 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.577443, -70.559381),
                    Label = "Feria Las Nieves oriente, Puente Alto",
                    Address = "Desde Gabriela oriente a El Peñón. Jueves  "
                },
            };

            var pin254 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.57224, -70.563308),
                    Label = "Feria El Peral, Puente Alto",
                    Address = "Desde México a Las Nieves. Martes  "
                },
            };

            var pin255 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.571275, -70.573865),
                    Label = "Feria El Peral, Puente Alto",
                    Address = "Desde Nonato Coo a El Hidalgo. Miércoles  "
                },
            };

            var pin256 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.569058, -70.580603),
                    Label = "Feria Los Toros, Puente Alto",
                    Address = "Desde vicuña Mackenna a Nemesio Vicuña. Domingos  "
                },
            };

            var pin257 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.567788, -70.569316),
                    Label = "Feria Los Toros, Puente Alto",
                    Address = "Desde Nonato Coo a México. Sábados  "
                },
            };

            var pin258 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.564946, -70.567192),
                    Label = "Feria México, Puente Alto",
                    Address = "Desde Los Toros a Bahía Inglesa. Jueves  "
                },
            };

            var pin259 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.558956, -70.555712),
                    Label = "Feria Diego Portales, Puente Alto",
                    Address = "Desde Los Pesqueros a Las Torres. Sábados  "
                },
            };

            var pin260 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.584486, -70.591756),
                    Label = "Feria Juan de Dios Malebran, Puente Alto",
                    Address = "Desde Gabriela a Luis Matte Larraín. Miércoles  "
                },
            };

            var pin261 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.582529, -70.590125),
                    Label = "Feria Miguel Ángel, Puente Alto",
                    Address = "Desde El Almendro a Coquimbo. Sábados  "
                },
            };

            var pin262 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.585898, -70.596959),
                    Label = "Feria Éjercito Libertador, Puente Alto",
                    Address = "Desde Luis Matte Larraín a Padre Hurtado. Jueves y Domingos"
                },
            };

            var pin263 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.58412, -70.6004478),
                    Label = "Feria Miguel Ángel, Puente Alto",
                    Address = "Desde Éjercito Libertador a Julio César. Martes  "
                },
            };

            var pin264 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.584209, -70.601884),
                    Label = "Feria Creta, Puente Alto",
                    Address = "Desde Sagasca a Gabriela. Viernes  "
                },
            };

            var pin265 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.588293, -70.602146),
                    Label = "Feria Luis Matte Larraín, Puente Alto",
                    Address = "Desde General Montino a El Abra. Miércoles y Sábados"
                },
            };

            var pin266 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.578757, -70.587603),
                    Label = "Feria Coquimbo, Puente Alto",
                    Address = "Desde Gabriela a Venus. Miércoles  "
                },
            };

            var pin267 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.58109, -70.569761),
                    Label = "Feria Troncal San Francisco, Puente Alto",
                    Address = "Desde El Peñón a Nonato Coo. Miércoles  "
                },
            };

            var pin268 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.569809, -70.609978),
                    Label = "Feria Troncal San Francisco, Puente Alto",
                    Address = "Desde Avenida La Serena a Los Cipreses. Viernes  "
                },
            };

            var pin269 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.60127, -70.563587),
                    Label = "Feria Domingo Tocornal, Puente Alto",
                    Address = "Desde Nonato Coo a Calle Uno. Viernes  "
                },
            };

            var pin270 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.629378, -70.587319),
                    Label = "Feria La Colonia, Puente Alto",
                    Address = "Desde La Colonia a Las Achiras. Miércoles  "
                },
            };

            var pin271 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.362148, -70.756813),
                    Label = "Feria Lo Marcoleta, Quilicura",
                    Address = "Desde Parroquia Jesús Obrero a San Luis. Miércoles  "
                },
            };

            var pin272 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.360983, -70.74881),
                    Label = "Feria Lo Marcoleta, Quilicura",
                    Address = "Desde Tres Monte a San Luis. Martes y Viernes"
                },
            };

            var pin273 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.363832, -70.749223),
                    Label = "Feria Volcán Villarrica, Quilicura",
                    Address = "Desde Matta a San Luis. Martes  "
                },
            };

            var pin274 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.3516, -70.746208),
                    Label = "Feria Los Alpes, Quilicura",
                    Address = "Desde Kilimanyaro a Los Cárpatos. Sábados  "
                },
            };

            var pin275 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.363832, -70.742952),
                    Label = "Feria San Enrique, Quilicura",
                    Address = "Desde Matta a San Luis. Domingos  "
                },
            };

            var pin276 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.367087, -70.745367),
                    Label = "Feria Toconao, Quilicura",
                    Address = "Desde Caspana a San Luis. Jueves  "
                },
            };

            var pin277 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.369298, -70.742866),
                    Label = "Feria Las violetas, Quilicura",
                    Address = "Desde San Martín a Antonio Varas. Sábados  "
                },
            };

            var pin278 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.357864, -70.731515),
                    Label = "Feria Lo Marcoleta, Quilicura",
                    Address = "Desde O'Higgins a Lo Ovalle. Viernes  "
                },
            };

            var pin279 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.361592, -70.729546),
                    Label = "Feria O'Higgins, Quilicura",
                    Address = "Desde Doña Leticia a Ana Frank. Sábados  "
                },
            };

            var pin280 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.357148, -70.718211),
                    Label = "Feria Lo Marcoleta, Quilicura",
                    Address = "Desde Lo Cruzat a Los Américanos. Sábados  "
                },
            };

            var pin281 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.364764, -70.71407),
                    Label = "Feria Séptimo de Línea, Quilicura",
                    Address = "Desde Matta a Los Maitenes. Jueves  "
                },
            };

            var pin282 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.368949, -70.716135),
                    Label = "Feria Carampangue, Quilicura",
                    Address = "Desde Lo Campino a Las Aguilas. Domingos  "
                },
            };

            var pin283 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.369621, -70.723323),
                    Label = "Feria Ramón Rosales, Quilicura",
                    Address = "Desde Osvaldo Lira a Canutillar. Miércoles  "
                },
            };

            var pin284 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.445533, -70.693358),
                    Label = "Feria Francisco Javier, Quinta Normal",
                    Address = "Desde Nueva Imperial a Alberto Edwards. Martes  "
                },
            };

            var pin285 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.446581, -70.694677),
                    Label = "Feria San Gumercindo, Quinta Normal",
                    Address = "Desde Nueva Imperial a Porto Seguro. Viernes  "
                },
            };

            var pin286 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.443653, -70.697976),
                    Label = "Feria Victorino Laynez, Quinta Normal",
                    Address = "Desde Nueva Imperial a Catedral. Miércoles  "
                },
            };

            var pin287 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.43778, -70.699623),
                    Label = "Feria Edison, Quinta Normal",
                    Address = "Desde Radal a Bismarck. Sábados  "
                },
            };

            var pin288 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.439105, -70.705293),
                    Label = "Feria José Besa, Quinta Normal",
                    Address = "Desde San Pablo a Vicuña Rozas. Martes  "
                },
            };

            var pin289 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.43357, -70.70132),
                    Label = "Feria Eduardo Charme, Quinta Normal",
                    Address = "Desde José Joaquín Pérez a Vicuña Rozas. Viernes  "
                },
            };

            var pin290 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.435811, -70.716725),
                    Label = "Feria Mercurio, Quinta Normal",
                    Address = "Desde camino de Loyola a Tránsito. Miércoles  "
                },
            };

            var pin291 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.433877, -70.717905),
                    Label = "Feria Tránsit, Quinta Normal",
                    Address = "Desde Neptuno a Venus. Viernes  "
                },
            };

            var pin292 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.429364, -70.713018),
                    Label = "Feria Alberdi, Quinta Normal",
                    Address = "Desde Mapocho a Río Baker. Miércoles  "
                },
            };

            var pin293 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.425621, -70.706345),
                    Label = "Feria Alsino, Quinta Normal",
                    Address = "Desde Radal a Bombero Roberts. Sábados  "
                },
            };

            var pin294 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.422004, -70.711001),
                    Label = "Feria Alberdi, Quinta Normal",
                    Address = "Desde Salvador Gutiérrez a Hoevel. Jueves y Domingos"
                },
            };

            var pin295 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.413917, -70.707069),
                    Label = "Feria Los Sauces, Quinta Normal",
                    Address = "Desde La Rioja a Lo Espinosa. Martes y Sábados"
                },
            };

            var pin296 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.416595, -70.699092),
                    Label = "Feria José Tobpias, Quinta Normal",
                    Address = "Desde Carlos Ottolenghi a Los Sauces. Jueves  "
                },
            };

            var pin297 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.417383, -70.697638),
                    Label = "Feria Marcelo fitte, Quinta Normal",
                    Address = "Desde Miguel de Atero a Aviador Bleriot. Domingos  "
                },
            };

            var pin298 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.427949, -70.690665),
                    Label = "Feria Augusto Matte, Quinta Normal",
                    Address = "Desde Juan de Barros a Claudio Vicuña Morla. Domingos  "
                },
            };

            var pin299 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.429686, -70.689114),
                    Label = "Feria Lope de Ulloa, Quinta Normal",
                    Address = "Desde Mapocho a Claudio Vicuña Morla. Jueves  "
                },
            };

            var pin300 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.404218, -70.657443),
                    Label = "Feria Guanaco, Recoleta",
                    Address = "Desde Einstein a México. Jueves y Domingos"
                },
            };

            var pin301 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.395121, -70.648777),
                    Label = "Feria La Serena, Recoleta",
                    Address = "Desde Recoleta a Diagonal Cardenal Caro. Domingos  "
                },
            };

            var pin302 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.388892, -70.646676),
                    Label = "Feria Zapadores, Recoleta",
                    Address = "Desde Recoleta a Juan Cristobal. Martes  "
                },
            };

            var pin303 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.397536, -70.631093),
                    Label = "Feria San José, Recoleta",
                    Address = "Desde Zapadores a Enrique Donoso. Jueves  "
                },
            };

            var pin304 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.400769, -70.639799),
                    Label = "Feria Rquel, Recoleta",
                    Address = "Desde Inocencia a Muñoz Gamero. Viernes  "
                },
            };

            var pin305 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.404128, -70.639145),
                    Label = "Feria Víctor Cuccuini, Recoleta",
                    Address = "Desde Coronel del Canto a Campino. Miércoles  "
                },
            };

            var pin306 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.406332, -70.637117),
                    Label = "Feria Einstein, Recoleta",
                    Address = "Desde Albano a Aurelio Díaz Meza. Sábados  "
                },
            };

            var pin307 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.41132, -70.629317),
                    Label = "Feria Arzobispo Valdivieso, Recoleta",
                    Address = "Desde Alicanto a 7 norte. Viernes  "
                },
            };

            var pin308 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.406511, -70.628727),
                    Label = "Feria Einstein, Recoleta",
                    Address = "Desde 3 de junio a Gabriela Mistral. Jueves  "
                },
            };

            var pin309 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.401988, -70.627493),
                    Label = "Feria Heroes de la Concepción, Recoleta",
                    Address = "Desde Reina de Chile a Colombia. Sábados  "
                },
            };

            var pin310 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.404352, -70.744931),
                    Label = "Feria Vicuña Mackenna, Renca",
                    Address = "Desde José Manuel Infante a Miraflores. Jueves y Domingos"
                },
            };

            var pin311 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.408651, -70.734352),
                    Label = "Feria Pelluhue, Renca",
                    Address = "Desde José Manuel Infante a Topocalma. Martes y Viernes"
                },
            };

            var pin312 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.407729, -70.726177),
                    Label = "Feria Condell, Renca",
                    Address = "Desde José Manuel Infante a Espino. Miércoles y Sábados"
                },
            };

            var pin313 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.402761, -70.725693),
                    Label = "Feria Colo Colo, Renca",
                    Address = "Desde General Freire a Arturo Prat. Jueves y Domingos"
                },
            };

            var pin314 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.395916, -70.723293),
                    Label = "Feria Manuel Rodríguez, Renca",
                    Address = "Desde Río Toltén a Llanquihue. Miércoles  "
                },
            };

            var pin315 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.401432, -70.711414),
                    Label = "Feria Diego Portales, Renca",
                    Address = "Desde Montt Varas a Ignacio Carrera Pinto. Martes y Viernes"
                },
            };

            var pin316 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.405848, -70.709118),
                    Label = "Feria Nicanor Fajardo, Renca",
                    Address = "Desde Domingo Santa María a Costanera Nortel. Miércoles y Sábados"
                },
            };

            var pin317 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.403188, -70.700868),
                    Label = "Feria José Manuel Balmaceda, Renca",
                    Address = "Desde Caupolicán a Diagonal poniente. Miércoles y Sábados"
                },
            };

            var pin318 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.406224, -70.691823),
                    Label = "Feria Los Acacios, Renca",
                    Address = "Desde Los Aromos a Pasaje Rubpi. Jueves y Domingos"
                },
            };

            var pin319 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.414329, -70.686212),
                    Label = "Feria Barros Arana, Renca",
                    Address = "Desde José Sarmiento Aldunate a Antonio Maceo. Miércoles y Sábados"
                },
            };

            var pin320 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.394284, -70.697941),
                    Label = "Feria Las Margaritas, Renca",
                    Address = "Desde Puerto Montt a Los Girasoles. Miércoles y Sábados"
                },
            };

            var pin321 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.399524, -70.700127),
                    Label = "Feria Los Clarines, Renca",
                    Address = "Desde Las Margaritas a Senador Jaime Guzmán. Martes y Viernes"
                },
            };

            var pin322 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.606762, -70.705281),
                    Label = "Feria Ramón Liberio Carvallo, San Bernardo",
                    Address = "Desde Barros Arana a Victoria. Sábados  "
                },
            };

            var pin323 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.591314, -70.71128),
                    Label = "Feria Costanera, San Bernardo",
                    Address = "Desde Colón a Covadonga. Jueves y Domingos"
                },
            };

            var pin324 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.57898, -70.704714),
                    Label = "Feria Yungay, San Bernardo",
                    Address = "Desde América a Santiago. Martes y Sábados"
                },
            };

            var pin325 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.596444, -70.695192),
                    Label = "Feria Antonio Varas, San Bernardo",
                    Address = "Desde Baquedano a José Besa. Jueves y Domingos"
                },
            };

            var pin326 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.584338, -70.688234),
                    Label = "Feria Francisco Camargo, San Bernardo",
                    Address = "Desde Calderón de la Barca a Santa Marta. Miércoles y Sábados"
                },
            };

            var pin327 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.590984, -70.685096),
                    Label = "Feria Balmaceda, San Bernardo",
                    Address = "Desde Martín de Solís a Diego de Medellín. Martes y Viernes"
                },
            };

            var pin328 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.595425, -70.67271),
                    Label = "Feria Balmaceda, San Bernardo",
                    Address = "Desde Padre Hurtado a San Francisco. Miércoles y Sábados"
                },
            };

            var pin329 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.584111, -70.668885),
                    Label = "Feria Lo Blanco, San Bernardo",
                    Address = "Desde Paso Drake a Océano Atlántico. Jueves y Domingos"
                },
            };

            var pin330 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.516657, -70.632772),
                    Label = "Feria Sebastopol, San Joaquín",
                    Address = "Desde Santa Rosa a Latinoamerica. Martes y Sábados"
                },
            };

            var pin331 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.512372, -70.622161),
                    Label = "Feria Vecinal, San Joaquín",
                    Address = "Desde Carmen Mena a Lo ovalle. Martes y Viernes"
                },
            };

            var pin332 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.502299, -70.633931),
                    Label = "Feria San Nicolás, San Joaquín",
                    Address = "Desde Santa Rosa a Avenida La Industria. Jueves y Domingos"
                },
            };

            var pin333 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.496457, -70.637771),
                    Label = "Feria Gaspar de Soto, San Joaquín",
                    Address = "Desde Santa Rosa a San Gregorio. Miércoles y Domingos"
                },
            };

            var pin334 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.494104, -70.621002),
                    Label = "Feria Comercio, San Joaquín",
                    Address = "Desde San Juan a Avenida Central. Martes y Viernes"
                },
            };

            var pin335 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.488833, -70.632847),
                    Label = "Feria Comandante Riesle, San Joaquín",
                    Address = "Desde Los Copihues a Juegos Infantiles. Jueves y Domingos"
                },
            };

            var pin336 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.479966, -70.627257),
                    Label = "Feria Juan Sebastián Bach, San Joaquín",
                    Address = "Desde Palestina a Lira. Miércoles  "
                },
            };

            var pin337 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.477189, -70.632937),
                    Label = "Feria Tocornal, San Joaquín",
                    Address = "Desde Isabel Riquelme a Carlos Fernández Concha. Sábados  "
                },
            };

            var pin338 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.508498, -70.646757),
                    Label = "Feria Chiloe, San Miguel",
                    Address = "Desde Varas Mena a Departamental. Viernes  "
                },
            };

            var pin339 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.500465, -70.662716),
                    Label = "Feria Tristán Matta, San Miguel",
                    Address = "Desde Gauss a José Joaquín Prieto Vial. Jueves y Domingos"
                },
            };

            var pin340 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.490086, -70.644552),
                    Label = "Feria San Francisco, San Miguel",
                    Address = "Desde Álvarez de Toledo a María Auxiliadora. Viernes  "
                },
            };

            var pin341 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.485845, -70.656477),
                    Label = "Feria Soto Aguilar, San Miguel",
                    Address = "Desde San Ignacio de Loyola a Ramón Barros Luco. Jueves y Domingos"
                },
            };

            var pin342 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.508769, -70.649376),
                    Label = "Feria Miguel Luis Cerda, San Miguel",
                    Address = "Desde León Prado a Varas Mena. Martes  "
                },
            };

            var pin343 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.508651, -70.667029),
                    Label = "Feria Octava Avenida, San Miguel",
                    Address = "Desde Cuarta Transversal a Quinta Transversal. Miércoles  "
                },
            };

            var pin344 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.548244, -70.645791),
                    Label = "Feria La Bandera, San Ramón",
                    Address = "Desde Vicuña Mackenna a Esperanza. Jueves y Domingos"
                },
            };

            var pin345 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.539374, -70.639933),
                    Label = "Feria Bolivia, San Ramón",
                    Address = "Desde Pedro Aguirre Cerda a Carlos Dávila. Miércoles y Sábados"
                },
            };

            var pin346 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.548226, -70.640706),
                    Label = "Feria Alpatacal, San Ramón",
                    Address = "Desde Almirante Latorre a Pedro Aguirre Cerda. Martes y Viernes"
                },
            };

            var pin347 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.535761, -70.649117),
                    Label = "Feria Emiliano Figueroa, San Ramón",
                    Address = "Desde Paraguay a Bolivia. Jueves y Domingos"
                },
            };

            var pin348 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.529626, -70.641435),
                    Label = "Feria Avenida El Parrón, San Ramón",
                    Address = "Desde Carlos Dávila a Juan Luis Sanfuentes. Martes y Viernes"
                },
            };

            var pin349 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.525816, -70.643946),
                    Label = "Feria Alvear, San Ramón",
                    Address = "Desde Los Tilos a Santa Ana. Jueves y Domingos"
                },
            };

            var pin350 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.520643, -70.641263),
                    Label = "Feria Bombero Gabriel Lima Millan, San Ramón",
                    Address = "Desde Rivadavia a Alvear. Miércoles y Sábados"
                },
            };

            var pin351 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.555254, -70.640105),
                    Label = "Feria Sargento Candelaria, San Ramón",
                    Address = "Desde Juan Antonio Rios a Pedro Aguirre Cerda. Miércoles y Sábados"
                },
            };

            var pin352 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.474408, -70.670934),
                    Label = "Feria San Agustín, Santiago",
                    Address = "Desde Bascuñan Guerrero a Francisco Pizarro. Sábados  "
                },
            };

            var pin353 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.467168, -70.675558),
                    Label = "Feria Gaspar de la Barreta, Santiago",
                    Address = "Desde Longavi a Melipilla. Jueves y Domingos"
                },
            };

            var pin354 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.456468, -70.647157),
                    Label = "Feria Coquimbo, Santiago",
                    Address = "Desde Nueva de Valdés a Los Alamos. Miércoles y Sábados"
                },
            };

            var pin355 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.456929, -70.65468),
                    Label = "Feria Aldunate, Santiago",
                    Address = "Desde Copiapo a Coquimbo. Jueves y Domingos"
                },
            };

            var pin356 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.447369, -70.671964),
                    Label = "Feria Romero, Santiago",
                    Address = "Desde Garcia Reyes a Libertad. Martes y Viernes"
                },
            };

            var pin357 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.444898, -70.675258),
                    Label = "Feria Esperanza, Santiago",
                    Address = "Desde Portales a Erasmo Escala. Domingos  "
                },
            };

            var pin358 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.443233, -70.675376),
                    Label = "Feria Portales, Santiago",
                    Address = "Desde Libertad a Maipú. Jueves  "
                },
            };

            var pin359 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.434271, -70.678219),
                    Label = "Feria Herrra, Santiago",
                    Address = "Desde San Pablo a Mapocho. Martes y Viernes"
                },
            };

            var pin360 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.433644, -70.666825),
                    Label = "Feria Martínez de Rozas, Santiago",
                    Address = "Desde Ricardo Cumming a Brasil. Miércoles y Sábados"
                },
            };

            var pin361 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.465262, -70.651773),
                    Label = "Feria Roberto Espinoza, Santiago",
                    Address = "Desde Victoria a Pedro Lagos. Sábados  "
                },
            };

            var pin362 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.464331, -70.63613),
                    Label = "Feria Pedro Lagos, Santiago",
                    Address = "Desde Lira a Carmen. Sábados  "
                },
            };

            var pin363 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.458307, -70.635068),
                    Label = "Feria Ventura Lavalle, Santiago",
                    Address = "Desde Cuevas a Lira. Martes  "
                },
            };

            var pin364 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.451692, -70.632675),
                    Label = "Feria 10 de julio, Santiago",
                    Address = "Desde Vicuña Mackenna a Portugal. Domingos  "
                },
            };

            var pin365 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.447601, -70.63451),
                    Label = "Feria Fray Camino Henríquez, Santiago",
                    Address = "Desde Argomedo a Marín. Miércoles y Viernes"
                },
            };

            var pin366 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.37858, -70.556906),
                    Label = "Feria El Aromo, Vitacura",
                    Address = "Desde Padre Hurtado a Escrivá de Balaguer sur. Jueves y Sábados"
                },
            };

            var pin367 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(-33.385318, -70.591324),
                    Label = "Feria Escrivá de Balaguer, Vitacura",
                    Address = "Desde Casamedar  . Jueves y Viernes"
                },
            };


            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin.Pin);
            customMap.Pins.Add(pin002.Pin);
            customMap.Pins.Add(pin003.Pin);
            customMap.Pins.Add(pin004.Pin);
            customMap.Pins.Add(pin005.Pin);
            customMap.Pins.Add(pin006.Pin);
            customMap.Pins.Add(pin007.Pin);
            customMap.Pins.Add(pin008.Pin);
            customMap.Pins.Add(pin009.Pin);
            customMap.Pins.Add(pin010.Pin);
            customMap.Pins.Add(pin011.Pin);
            customMap.Pins.Add(pin012.Pin);
            customMap.Pins.Add(pin013.Pin);
            customMap.Pins.Add(pin014.Pin);
            customMap.Pins.Add(pin015.Pin);
            customMap.Pins.Add(pin016.Pin);
            customMap.Pins.Add(pin017.Pin);
            customMap.Pins.Add(pin018.Pin);
            customMap.Pins.Add(pin019.Pin);
            customMap.Pins.Add(pin020.Pin);
            customMap.Pins.Add(pin021.Pin);
            customMap.Pins.Add(pin022.Pin);
            customMap.Pins.Add(pin023.Pin);
            customMap.Pins.Add(pin024.Pin);
            customMap.Pins.Add(pin025.Pin);
            customMap.Pins.Add(pin027.Pin);
            customMap.Pins.Add(pin028.Pin);
            customMap.Pins.Add(pin029.Pin);
            customMap.Pins.Add(pin030.Pin);
            customMap.Pins.Add(pin031.Pin);
            customMap.Pins.Add(pin032.Pin);
            customMap.Pins.Add(pin033.Pin);
            customMap.Pins.Add(pin034.Pin);
            customMap.Pins.Add(pin035.Pin);
            customMap.Pins.Add(pin036.Pin);
            customMap.Pins.Add(pin037.Pin);
            customMap.Pins.Add(pin038.Pin);
            customMap.Pins.Add(pin039.Pin);
            customMap.Pins.Add(pin040.Pin);
            customMap.Pins.Add(pin041.Pin);
            customMap.Pins.Add(pin042.Pin);
            customMap.Pins.Add(pin043.Pin);
            customMap.Pins.Add(pin044.Pin);
            customMap.Pins.Add(pin045.Pin);
            customMap.Pins.Add(pin046.Pin);
            customMap.Pins.Add(pin047.Pin);
            customMap.Pins.Add(pin048.Pin);
            customMap.Pins.Add(pin049.Pin);
            customMap.Pins.Add(pin050.Pin);
            customMap.Pins.Add(pin051.Pin);
            customMap.Pins.Add(pin052.Pin);
            customMap.Pins.Add(pin053.Pin);
            customMap.Pins.Add(pin054.Pin);
            customMap.Pins.Add(pin055.Pin);
            customMap.Pins.Add(pin056.Pin);
            customMap.Pins.Add(pin057.Pin);
            customMap.Pins.Add(pin058.Pin);
            customMap.Pins.Add(pin059.Pin);
            customMap.Pins.Add(pin060.Pin);
            customMap.Pins.Add(pin061.Pin);
            customMap.Pins.Add(pin062.Pin);
            customMap.Pins.Add(pin063.Pin);
            customMap.Pins.Add(pin064.Pin);
            customMap.Pins.Add(pin065.Pin);
            customMap.Pins.Add(pin066.Pin);
            customMap.Pins.Add(pin067.Pin);
            customMap.Pins.Add(pin068.Pin);
            customMap.Pins.Add(pin069.Pin);
            customMap.Pins.Add(pin070.Pin);
            customMap.Pins.Add(pin071.Pin);
            customMap.Pins.Add(pin072.Pin);
            customMap.Pins.Add(pin073.Pin);
            customMap.Pins.Add(pin074.Pin);
            customMap.Pins.Add(pin075.Pin);
            customMap.Pins.Add(pin077.Pin);
            customMap.Pins.Add(pin078.Pin);
            customMap.Pins.Add(pin079.Pin);
            customMap.Pins.Add(pin080.Pin);
            customMap.Pins.Add(pin081.Pin);
            customMap.Pins.Add(pin082.Pin);
            customMap.Pins.Add(pin083.Pin);
            customMap.Pins.Add(pin084.Pin);
            customMap.Pins.Add(pin085.Pin);
            customMap.Pins.Add(pin086.Pin);
            customMap.Pins.Add(pin087.Pin);
            customMap.Pins.Add(pin088.Pin);
            customMap.Pins.Add(pin089.Pin);
            customMap.Pins.Add(pin090.Pin);
            customMap.Pins.Add(pin091.Pin);
            customMap.Pins.Add(pin092.Pin);
            customMap.Pins.Add(pin093.Pin);
            customMap.Pins.Add(pin094.Pin);
            customMap.Pins.Add(pin095.Pin);
            customMap.Pins.Add(pin096.Pin);
            customMap.Pins.Add(pin097.Pin);
            customMap.Pins.Add(pin098.Pin);
            customMap.Pins.Add(pin099.Pin);
            customMap.Pins.Add(pin100.Pin);
            customMap.Pins.Add(pin101.Pin);
            customMap.Pins.Add(pin102.Pin);
            customMap.Pins.Add(pin103.Pin);
            customMap.Pins.Add(pin104.Pin);
            customMap.Pins.Add(pin105.Pin);
            customMap.Pins.Add(pin106.Pin);
            customMap.Pins.Add(pin107.Pin);
            customMap.Pins.Add(pin108.Pin);
            customMap.Pins.Add(pin109.Pin);
            customMap.Pins.Add(pin110.Pin);
            customMap.Pins.Add(pin111.Pin);
            customMap.Pins.Add(pin112.Pin);
            customMap.Pins.Add(pin113.Pin);
            customMap.Pins.Add(pin114.Pin);
            customMap.Pins.Add(pin115.Pin);
            customMap.Pins.Add(pin116.Pin);
            customMap.Pins.Add(pin117.Pin);
            customMap.Pins.Add(pin118.Pin);
            customMap.Pins.Add(pin119.Pin);
            customMap.Pins.Add(pin120.Pin);
            customMap.Pins.Add(pin121.Pin);
            customMap.Pins.Add(pin122.Pin);
            customMap.Pins.Add(pin123.Pin);
            customMap.Pins.Add(pin124.Pin);
            customMap.Pins.Add(pin125.Pin);
            customMap.Pins.Add(pin126.Pin);
            customMap.Pins.Add(pin127.Pin);
            customMap.Pins.Add(pin128.Pin);
            customMap.Pins.Add(pin129.Pin);
            customMap.Pins.Add(pin130.Pin);
            customMap.Pins.Add(pin131.Pin);
            customMap.Pins.Add(pin132.Pin);
            customMap.Pins.Add(pin133.Pin);
            customMap.Pins.Add(pin134.Pin);
            customMap.Pins.Add(pin135.Pin);
            customMap.Pins.Add(pin136.Pin);
            customMap.Pins.Add(pin137.Pin);
            customMap.Pins.Add(pin138.Pin);
            customMap.Pins.Add(pin139.Pin);
            customMap.Pins.Add(pin140.Pin);
            customMap.Pins.Add(pin141.Pin);
            customMap.Pins.Add(pin142.Pin);
            customMap.Pins.Add(pin143.Pin);
            customMap.Pins.Add(pin144.Pin);
            customMap.Pins.Add(pin145.Pin);
            customMap.Pins.Add(pin146.Pin);
            customMap.Pins.Add(pin147.Pin);
            customMap.Pins.Add(pin148.Pin);
            customMap.Pins.Add(pin149.Pin);
            customMap.Pins.Add(pin150.Pin);
            customMap.Pins.Add(pin151.Pin);
            customMap.Pins.Add(pin152.Pin);
            customMap.Pins.Add(pin153.Pin);
            customMap.Pins.Add(pin154.Pin);
            customMap.Pins.Add(pin155.Pin);
            customMap.Pins.Add(pin156.Pin);
            customMap.Pins.Add(pin157.Pin);
            customMap.Pins.Add(pin158.Pin);
            customMap.Pins.Add(pin159.Pin);
            customMap.Pins.Add(pin160.Pin);
            customMap.Pins.Add(pin161.Pin);
            customMap.Pins.Add(pin162.Pin);
            customMap.Pins.Add(pin163.Pin);
            customMap.Pins.Add(pin164.Pin);
            customMap.Pins.Add(pin165.Pin);
            customMap.Pins.Add(pin166.Pin);
            customMap.Pins.Add(pin167.Pin);
            customMap.Pins.Add(pin168.Pin);
            customMap.Pins.Add(pin169.Pin);
            customMap.Pins.Add(pin171.Pin);
            customMap.Pins.Add(pin170.Pin);
            customMap.Pins.Add(pin172.Pin);
            customMap.Pins.Add(pin173.Pin);
            customMap.Pins.Add(pin174.Pin);
            customMap.Pins.Add(pin175.Pin);
            customMap.Pins.Add(pin176.Pin);
            customMap.Pins.Add(pin177.Pin);
            customMap.Pins.Add(pin178.Pin);
            customMap.Pins.Add(pin179.Pin);
            customMap.Pins.Add(pin180.Pin);
            customMap.Pins.Add(pin181.Pin);
            customMap.Pins.Add(pin182.Pin);
            customMap.Pins.Add(pin183.Pin);
            customMap.Pins.Add(pin184.Pin);
            customMap.Pins.Add(pin185.Pin);
            customMap.Pins.Add(pin186.Pin);
            customMap.Pins.Add(pin187.Pin);
            customMap.Pins.Add(pin188.Pin);
            customMap.Pins.Add(pin189.Pin);
            customMap.Pins.Add(pin190.Pin);
            customMap.Pins.Add(pin191.Pin);
            customMap.Pins.Add(pin192.Pin);
            customMap.Pins.Add(pin193.Pin);
            customMap.Pins.Add(pin194.Pin);
            customMap.Pins.Add(pin195.Pin);
            customMap.Pins.Add(pin196.Pin);
            customMap.Pins.Add(pin197.Pin);
            customMap.Pins.Add(pin198.Pin);
            customMap.Pins.Add(pin199.Pin);
            customMap.Pins.Add(pin200.Pin);
            customMap.Pins.Add(pin201.Pin);
            customMap.Pins.Add(pin202.Pin);
            customMap.Pins.Add(pin203.Pin);
            customMap.Pins.Add(pin204.Pin);
            customMap.Pins.Add(pin205.Pin);
            customMap.Pins.Add(pin206.Pin);
            customMap.Pins.Add(pin207.Pin);
            customMap.Pins.Add(pin208.Pin);
            customMap.Pins.Add(pin209.Pin);
            customMap.Pins.Add(pin210.Pin);
            customMap.Pins.Add(pin211.Pin);
            customMap.Pins.Add(pin212.Pin);
            customMap.Pins.Add(pin213.Pin);
            customMap.Pins.Add(pin214.Pin);
            customMap.Pins.Add(pin215.Pin);
            customMap.Pins.Add(pin216.Pin);
            customMap.Pins.Add(pin217.Pin);
            customMap.Pins.Add(pin218.Pin);
            customMap.Pins.Add(pin219.Pin);
            customMap.Pins.Add(pin220.Pin);
            customMap.Pins.Add(pin221.Pin);
            customMap.Pins.Add(pin222.Pin);
            customMap.Pins.Add(pin223.Pin);
            customMap.Pins.Add(pin224.Pin);
            customMap.Pins.Add(pin225.Pin);
            customMap.Pins.Add(pin226.Pin);
            customMap.Pins.Add(pin227.Pin);
            customMap.Pins.Add(pin228.Pin);
            customMap.Pins.Add(pin229.Pin);
            customMap.Pins.Add(pin230.Pin);
            customMap.Pins.Add(pin231.Pin);
            customMap.Pins.Add(pin232.Pin);
            customMap.Pins.Add(pin233.Pin);
            customMap.Pins.Add(pin234.Pin);
            customMap.Pins.Add(pin235.Pin);
            customMap.Pins.Add(pin236.Pin);
            customMap.Pins.Add(pin237.Pin);
            customMap.Pins.Add(pin238.Pin);
            customMap.Pins.Add(pin239.Pin);
            customMap.Pins.Add(pin240.Pin);
            customMap.Pins.Add(pin241.Pin);
            customMap.Pins.Add(pin242.Pin);
            customMap.Pins.Add(pin243.Pin);
            customMap.Pins.Add(pin244.Pin);
            customMap.Pins.Add(pin245.Pin);
            customMap.Pins.Add(pin246.Pin);
            customMap.Pins.Add(pin247.Pin);
            customMap.Pins.Add(pin248.Pin);
            customMap.Pins.Add(pin249.Pin);
            customMap.Pins.Add(pin250.Pin);
            customMap.Pins.Add(pin251.Pin);
            customMap.Pins.Add(pin252.Pin);
            customMap.Pins.Add(pin253.Pin);
            customMap.Pins.Add(pin254.Pin);
            customMap.Pins.Add(pin255.Pin);
            customMap.Pins.Add(pin256.Pin);
            customMap.Pins.Add(pin257.Pin);
            customMap.Pins.Add(pin258.Pin);
            customMap.Pins.Add(pin259.Pin);
            customMap.Pins.Add(pin260.Pin);
            customMap.Pins.Add(pin261.Pin);
            customMap.Pins.Add(pin262.Pin);
            customMap.Pins.Add(pin263.Pin);
            customMap.Pins.Add(pin264.Pin);
            customMap.Pins.Add(pin265.Pin);
            customMap.Pins.Add(pin266.Pin);
            customMap.Pins.Add(pin267.Pin);
            customMap.Pins.Add(pin268.Pin);
            customMap.Pins.Add(pin269.Pin);
            customMap.Pins.Add(pin270.Pin);
            customMap.Pins.Add(pin271.Pin);
            customMap.Pins.Add(pin272.Pin);
            customMap.Pins.Add(pin273.Pin);
            customMap.Pins.Add(pin274.Pin);
            customMap.Pins.Add(pin275.Pin);
            customMap.Pins.Add(pin276.Pin);
            customMap.Pins.Add(pin277.Pin);
            customMap.Pins.Add(pin278.Pin);
            customMap.Pins.Add(pin279.Pin);
            customMap.Pins.Add(pin280.Pin);
            customMap.Pins.Add(pin281.Pin);
            customMap.Pins.Add(pin282.Pin);
            customMap.Pins.Add(pin283.Pin);
            customMap.Pins.Add(pin284.Pin);
            customMap.Pins.Add(pin285.Pin);
            customMap.Pins.Add(pin286.Pin);
            customMap.Pins.Add(pin287.Pin);
            customMap.Pins.Add(pin288.Pin);
            customMap.Pins.Add(pin289.Pin);
            customMap.Pins.Add(pin290.Pin);
            customMap.Pins.Add(pin291.Pin);
            customMap.Pins.Add(pin292.Pin);
            customMap.Pins.Add(pin293.Pin);
            customMap.Pins.Add(pin294.Pin);
            customMap.Pins.Add(pin295.Pin);
            customMap.Pins.Add(pin296.Pin);
            customMap.Pins.Add(pin297.Pin);
            customMap.Pins.Add(pin298.Pin);
            customMap.Pins.Add(pin299.Pin);
            customMap.Pins.Add(pin300.Pin);
            customMap.Pins.Add(pin301.Pin);
            customMap.Pins.Add(pin302.Pin);
            customMap.Pins.Add(pin303.Pin);
            customMap.Pins.Add(pin304.Pin);
            customMap.Pins.Add(pin305.Pin);
            customMap.Pins.Add(pin306.Pin);
            customMap.Pins.Add(pin307.Pin);
            customMap.Pins.Add(pin308.Pin);
            customMap.Pins.Add(pin309.Pin);
            customMap.Pins.Add(pin310.Pin);
            customMap.Pins.Add(pin311.Pin);
            customMap.Pins.Add(pin312.Pin);
            customMap.Pins.Add(pin313.Pin);
            customMap.Pins.Add(pin314.Pin);
            customMap.Pins.Add(pin315.Pin);
            customMap.Pins.Add(pin316.Pin);
            customMap.Pins.Add(pin317.Pin);
            customMap.Pins.Add(pin318.Pin);
            customMap.Pins.Add(pin319.Pin);
            customMap.Pins.Add(pin320.Pin);
            customMap.Pins.Add(pin321.Pin);
            customMap.Pins.Add(pin322.Pin);
            customMap.Pins.Add(pin323.Pin);
            customMap.Pins.Add(pin324.Pin);
            customMap.Pins.Add(pin325.Pin);
            customMap.Pins.Add(pin326.Pin);
            customMap.Pins.Add(pin327.Pin);
            customMap.Pins.Add(pin328.Pin);
            customMap.Pins.Add(pin329.Pin);
            customMap.Pins.Add(pin330.Pin);
            customMap.Pins.Add(pin331.Pin);
            customMap.Pins.Add(pin332.Pin);
            customMap.Pins.Add(pin333.Pin);
            customMap.Pins.Add(pin334.Pin);
            customMap.Pins.Add(pin335.Pin);
            customMap.Pins.Add(pin336.Pin);
            customMap.Pins.Add(pin337.Pin);
            customMap.Pins.Add(pin338.Pin);
            customMap.Pins.Add(pin339.Pin);
            customMap.Pins.Add(pin340.Pin);
            customMap.Pins.Add(pin341.Pin);
            customMap.Pins.Add(pin342.Pin);
            customMap.Pins.Add(pin343.Pin);
            customMap.Pins.Add(pin344.Pin);
            customMap.Pins.Add(pin345.Pin);
            customMap.Pins.Add(pin346.Pin);
            customMap.Pins.Add(pin347.Pin);
            customMap.Pins.Add(pin348.Pin);
            customMap.Pins.Add(pin349.Pin);
            customMap.Pins.Add(pin350.Pin);
            customMap.Pins.Add(pin351.Pin);
            customMap.Pins.Add(pin352.Pin);
            customMap.Pins.Add(pin353.Pin);
            customMap.Pins.Add(pin354.Pin);
            customMap.Pins.Add(pin355.Pin);
            customMap.Pins.Add(pin356.Pin);
            customMap.Pins.Add(pin357.Pin);
            customMap.Pins.Add(pin358.Pin);
            customMap.Pins.Add(pin359.Pin);
            customMap.Pins.Add(pin360.Pin);
            customMap.Pins.Add(pin361.Pin);
            customMap.Pins.Add(pin362.Pin);
            customMap.Pins.Add(pin363.Pin);
            customMap.Pins.Add(pin364.Pin);
            customMap.Pins.Add(pin365.Pin);
            customMap.Pins.Add(pin366.Pin);
            customMap.Pins.Add(pin367.Pin);


            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-33.513988, -70.785189), Distance.FromMiles(1.0)));

            Content = customMap;
        }
    }
}