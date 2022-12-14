## Builder Design Pattern

## [Implementation](./Implementation/IBuilder.cs)-[Best Practice](./BestPractice) And [How To Use](./UseBuilder.cs)
 


### **`GOF:`**

جدا کردن پیچیدگی های ساخت ابجکت از بخش نمایشیه ان

در نتیجه یک فرایند ساخت میتواند نمایش های مختلفی اراعه بدهد

(نمایشی = representation)

( معادل بهتری به ذهنم نرسید اگه شما معادلی دارید حتما پیشنهاد بدید)

### **`Concept:`**


این پترن برای زمانی مفید است که ابجکتی پیچیده دارید که از چند قسمت و بخش 
تشکیل شده است

فرایند ساخت ابجکت باید مستقل عمل کند

به تعریفی دیگر فرایند ساخت ابجکت اهمیتی نمیدهد که این قسمت ها چگونه سرهم 
میشوند

درواقع با پیاده سازی این پترن شما باید قادر باشید که با یک فرایند ساخت و ساز

اشکال مختلفی از ابجکت را به دست بیارید

![Builder Relations](../../Images/builder_1.png "Relations In This Pattern Accoding To GOF")


همونطور که در تصویر میبینید 

`product:`

یک ابجکت پیچیده و خروجی نهایی اپلیکیشن میباشد

`Builder:` 

یک اینترفیس شامله متود هایی است که قسمت های مختلفی از محصول نهایی را میسازد

`ConcreteBuilder:`

اینترفیسه سازنده رو پیاده سازی میکند و قسمت های مختلف ابجکته نهایی را سرهم میکند

این کلاس یک شکل داخلی از محصول نهایی را میسازد و یک متود برای دسترسی به آن نمونه اراعه میدهد

`Director:`

مسعولیت ساخت ابجکت نهایی به وسیله اینترفیس سازنده را دارد

توجه کنید این کلاس یا ابجکت تصمیم میگیرد که ترتیب مراحل ساخت چگونه باشد

پس میتوانیم بگوییم که توسط این کلاس میشود ترتیب و چگونگی مراحل را تعقیر داد 
تا خروجی متفاوتی حاصل شود.

##

**تصور کنید:** 

شما میتوانید یک کامپیوتر را با مشخصات مختلفی بخرید

شخصی کامپیوتری با یک هارد 1 ترابایتی و بدون گرافیک تهیه میکند

شخص دیگری ممکن است با گرافیک یا یک سی پی یوِ متفاوت کامپیوترش را تهیه کند

محصول نهایی اینجا کامپیوتر است

و خریدار نقش همان

`Director`

را دارد

و فروشنده یا کسی که قطعات را سرهم میکند درواقع همان 

`ConcreteBuilder` میباشد


# FAQ 

**> مزایای استفاده از این پترن**

- یک فرایند ساخت ثابت میتواند محصولات مختلفی اراعه بدهد
- میتوانید شکل داخلی محصول را تعقیر دهید
- در سطح بالای کد شما فقط یک متود دارید که میتواند یک محصول کامل تولید کنید و تمام پیچیدگی های ابجکت را مخفی میکنید

##

**> اشکالات مربوط به این پترن**

-  `mutable objects` ناسازگار با
- ممکن است مجبور شوید بعضی قسمت های کد رو تکرار کنید که خب اتفاق چندان جالبی نیست
-  `ConcreteBuilder` ساخت تعداد زیادی کلاس
(برای هر تایپ از ابجکت باید یک کلاس جدا بسازید)

##
**> abstract class or interface?**

میتونید از هر دو مدل برای تعریف این پترن استفاده کنید بستگی به نیاز های خودتون داره

##

**> Director**

استفاده از این کلاس هم اپشنال هستش

تمام کدهای این کلاس میتونه مستقیما توی کد های کلاینت قرار بگیره

*(منظور از کلاینت در اینجا قسمتی از کد هست که در حال استفاده از این پترن یا سیستم میباشد)*

##

