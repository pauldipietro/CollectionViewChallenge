### Screenshots ###

###### Android ######
<img src="https://github.com/er7santana/CollectionViewChallenge/blob/master/screenshots/android_image.gif" width="250px"/>

###### iOS ######
<img src="https://github.com/er7santana/CollectionViewChallenge/blob/master/screenshots/ios_image.png" width="250px"/>

### What went well? ###

It was very easy and smooth the implementation. The new layout options such as HorizontalList, GridList are amazing and are going to substitute lots of "extra work" that we need to do today.

### What didn't go well? ###

Actually, the only tiny issue that I faced in Android platform was that I was using a Grid with 3 rows, 1 for an Image, and 2 for Labels. 
Using ListView, I was able to set the rows heights as "Auto" for the labels and it worked as expected, but with CollectionView I had to specify the Height of the row with a real value, otherwise the rows with the Labels were not visible in Android devices, the first row with the image occupied all the ItemTemplate space. 

### How is the performance? ###

I didn't have any problems with performance. I think it's just fine.

### Missing or Desired Things: ###

I think it would be interesting to have a PullToRefresh feature just like ListView.
