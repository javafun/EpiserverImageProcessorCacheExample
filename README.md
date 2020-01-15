# EpiserverImageProcessorCacheExample

This repo is only for demo how Episerver ImageProcessor cache the different size images. 

The default cache configuration for Episerver ImageProcessor can be located at `/config/imageprocessor/cache.config`. It implements the provider pattern, and default storage is under blob folder. You can swtich the `currentCache` to `DiskCache` which will store the resized images under `~/app_data/cache` folder
https://github.com/javafun/EpiserverImageProcessorCacheExample/blob/8facd88c2ab46739aed9f85b5effbe188d044e4b/EpiserverImageProcessorCache/config/imageprocessor/cache.config

```xml

<?xml version="1.0" encoding="utf-8"?>
<caching currentCache="EpiserverBlobCache">
  <caches>
    <cache name="DiskCache" type="ImageProcessor.Web.Caching.DiskCache, ImageProcessor.Web" maxDays="365" memoryMaxMinutes="1" browserMaxDays="7">
      <settings>
        <setting key="VirtualCachePath" value="~/app_data/cache"/>
      </settings>
    </cache>
    <cache name="EpiserverBlobCache" type="ImageProcessor.Web.Episerver.FileBlobCache, ImageProcessor.Web.Episerver" maxDays="365" browserMaxDays="7">
      <settings/>
    </cache>
  </caches>
</caching>

```
