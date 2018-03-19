# DonareDeSangeee
# ISS Team
Inainte sa rulati programul trebuie mai intai sa rulati urmatoarele comezi.
Tools->Nuget Package Manager -> Package Manager Console
>RUN: Install-Package Microsoft.EntityFrameworkCore.SqlServer
>RUN: Install-Package Microsoft.EntityFrameworkCore.Tools

Daca nu va merge nici cu astea instalate puteti incerca si sa modificati ConfigurationString asa:

"Data Source=.; Initial Catalog=CentruTransfuzii;Integrated Security=True;"