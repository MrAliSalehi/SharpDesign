## Prototype Design Pattern

## [Implementation](./Implementation/AnimalBase.cs) And [How To Use](./UsePrototype.cs)


### **`GOF:`**

مشخص کردن نوع ابجکتی که قصد ساخت ان را داریم

به وسیله کپی کردنه یک نمونه اولیه  


### **`Concept:`**


این پترن یک راه جدید برای نمونه سازی از ابجکت ها به وصیله کلون کردن ان ها اراعه میدهد

به وصیله این مفهوم میتوانید هزینه ساخت ابجکت جدید را کاهش دهید

ایده اصلی این پترن ساخت یک ابجکت بر اساس ابجکت دیگر است

ابجکت فعلی به صورت یک تمپلیت عمل میکند


تصور کنید یک داکیومنت ارزشمند و مهم دارید و میخواید تعقیراتی روی اون اعمال کنید و نتایج رو ببینید

خب هرگز ریسک نمیکنید و روی داکیومنت اصلی تعقیرات رو اعمال نمیکنید

یک کپی ازش میگیرید و با اون کار میکنید




# FAQ

**> System.ICloneable**

من از اینترفیسی که خودم ساختم استفاده کردم برای اینکه صرفا جنریک باشه و ابجکت برنگردونم

ولی شما میتونید از اینترفیس داخلیه دات نت استفاده کنید.

##

**> چرا از این پترن استفاده کنیم ؟**


- نمیخواهید روی ابجکت فعلی ازمایشات و تعقیراتی انجام دهید


- در بعضی موارد میتوانید با هزینه کمتر نمونه سازی کنید


- نمونه سازی از برخی ابجکت ها میتواند پیچیده و دشوار باشد در این شرایط میتونید با کلون کردن ابجکت روی مشگل اصلی تمرکز کنید


- میخواهید قبل از تعریف کامل یک بخش از کد رفتار یک ابجکت جدید را داشته باشید ولی با دردسر و هزینه کمتر


**> سختی های استفاده از این پترن**

- تمامی کلاس هایی که از این پترن ارث بری میکنند حتما باید متود کلون رو پیاده سازی کنند
- ممکن است کلون کردن یک ابجکت تو در تو سخت و دشوار باشد

*([shallow copy vs deep copy](https://stackoverflow.com/questions/184710/what-is-the-difference-between-a-deep-copy-and-a-shallow-copy))*

