1. Install `mono-git`. I have version: `Mono JIT compiler version 4.3.0 (master/5b16d22 Tue Sep  8 22:56:44 PDT 2015)`

2. Install the Reference PCL Assemblies:

    ```shell
    curl -sS http://storage.bos.xamarin.com/bot-provisioning/PortableReferenceAssemblies-2014-04-14.zip > /tmp/pcl-assemblies.zip
    unzip /tmp/pcl-assemblies.zip -d /tmp/pcl-assemblies && mv /tmp/pcl-assemblies/PortableReferenceAssemblies-2014-04-14 /tmp/pcl-assemblies/.NETPortable
    export XBUILD_FRAMEWORK_FOLDERS_PATH=/tmp/pcl-assemblies/
    ```

3. now I get new errors to investigate later
