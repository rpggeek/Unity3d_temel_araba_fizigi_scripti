# Unity3d-temel-araba-fizi-i-scripti
## Türkçe

Temel araba fiziği,iki adet script dosyası içerir.Biri araba sürüş deneyimi için,bir diğeri gerçekçi bir süspansiyon simülasyonu için.
Scripti kullanmadan önce,ihtiyacınız olan 3D bir araç,ve ya her hangi bir nesne olabilir.Yapmanız gereken,Tekerlerin eklenmesi,ardından WheelCollider lerin tekerleklere entegrasyonu.3D ana objemize rigidbody ekliyoruz,bulunan iki scripti ana objemize ekliyoruz.
Tekerlekleri süspansiyon scriptimizin tekerlek kisimina ekliyoruz,ardından WheelColliderleri ekliyoruz.
Script içinde Tekerleklerin sırası ile WheelColliderlerin sırası aynı olmalı.

Şu şekilde olmalı:
Tekerlek1
Tekerlek2
Tekerlek3
Tekerlek4
WheelCollider1
WheelCollider2
WheelCollider3
WheelCollider4

Brawo ! Artık nispeten gerçekçi bir araba deneyimine sahipsiniz,daha gerçekçi fizik simülasyonu için rigidbody değerleri el ile ayarlanabilir.


## English

The basic car physics,it includes two script file.The first one for realistic driving experience and the another one for realistic suspension simulation.
Before using the script,what you need to is a 3D car object or any 3D object that you want to use.
What you need to do before using this script thoroughly is that,to add wheels and then integration of WheelColliders into wheels.
We're add a rigidbody component to our 3D parent object,thereafter add the two script file to on it.
We're add wheels into wheel part of the suspension script and after that we're add wheel colliders into it same way.
The order of wheels and Wheel Colliders in the script must be same.
It must be like this:
Wheel1
Wheel2
Wheel3
Wheel4
WheelCollider1
WheelCollider2
WheelCollider3
WheelCollider4

Congratulations ! Now you have comparatively-realistic car driwing experience.It can be adjustable for more realistic physics. simulation.
