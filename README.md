# fbx sdk c# wrapper


---

FbxWrapper是fbx sdk的c#封装。目的是为了方便fbx工具的开发，同时也可以方便的与Unity集成。代码使用[SWIG][1]生成。目前使用[fbx 2016 vs2013版本][2]。想要升级到最新的fbx sdk版本应该不会很难。
### 实现

 - 首先要以正确的顺序include所有的头文件。为此实现了一个小工具**IncludeGraph**，用于对所有的头文件根据依赖关系进行排序，去除循环依赖。
 - 首先需要引入平台相关的宏定义
```cplusplus
#define _WIN32
#define _WIN64
#define _MSC_VER 1800
#define _M_X64
```
 - 个别头文件需要小幅修改。swig的parser不能支持某些c++语法，例如
```cplusplus
typedef const double(kDouble44)[4][4] ;
```
```cplusplus
const static int sTypeTextureStartIndex = int(eTextureDiffuse);
```
 - swig不能自动实例化模板，一些关键的模板类需要手动实例化，否则这些模板类会被忽略。需要注意的是，手动实例化的位置有限制，需要在模板类定义之后，被使用之前。例如
 ```
%template(FbxDouble2) FbxVectorTemplate2<FbxDouble>;
%template(FbxDouble3) FbxVectorTemplate3<FbxDouble>;
%template(FbxDouble4) FbxVectorTemplate4<FbxDouble>;
%template(FbxDouble4x4) FbxVectorTemplate4<FbxDouble4>;
%template(FbxLayerElementTemplateFbxInt)FbxLayerElementTemplate<int>;
%template(FbxLayerElementTemplateFbxDouble)FbxLayerElementTemplate<double>;
 ```
 目前只实例化了部分常用的模板，遇到需要可以方便的加入新的模板实例。

 - fbx sdk的很多接口需要先获得基类指针，然后再down cast，例如
    ```cplusplus
    FbxAnimStack* pAnimStack = FbxCast<FbxAnimStack>(pScene->GetSrcObject(FBX_TYPE(FbxAnimStack), n)
    ```
    默认的情况下c#代码中不能处理这种情况。这里使用扩展方法构造子类对象的方法实现down cast，例如
    ```
    %extend FbxAnimStack {
      static FbxAnimStack *Cast(FbxObject *base) {
        return FbxCast<FbxAnimStack>(base);
      }
};
    ```
    c#中可以这样
    ```csharp
    FbxObject obj = scene.GetSrcObject(FbxAnimStack.ClassId, 0);
    FbxAnimStack stack = FbxAnimStack.Cast(obj);
    ```
    同样，目前只实现了少量常用的类型。需要是很容易加入新的类型转换。
 - 用rename处理运算符重载，例如
```cplusplus
 %rename(add)             operator+;
 %rename(pos)             operator+();
 %rename(sub)             operator-;
 %rename(neg)             operator-();
```
 - 有一些符号在lib中不存在，会导致链接不过，原因未知。只得忽略掉这些符号。还有一些生成的代码中会引  用protect成员，也一并忽略掉
```
%ignore FbxSelectionToTimeFormat;
%ignore FbxSelectionToTimeMode;
%ignore FbxTimeToSelection;
%ignore PropertyNotify;
%ignore FbxLayeredTexture::mInputData;
%ignore FbxImporter::SetPassword;
%ignore FbxSubDiv::SetLevelCount;
%ignore FbxImplementation::sDefaultType;
```
 - 引入指针数组对象，用于访问数据
```
%include "carrays.i"
%include "cpointer.i"

%array_class(double, DoubleArray);
%array_class(float, FloatArray);
%array_class(int, IntArray);
```

### 内容说明

 - **adapter** c#接口封装
 - **FbxWrapperDll** fbx c++接口
 - **IncludeGraph** 根据依赖关系排序头文件的工具
 - **header** 修改后的fbx sdk头文件
 - **test** sample代码
 - **fbxwapper.i** swig接口声明
 - **generate.cmd** 调用swig的命令行

  [1]: http://swig.org/
  [2]: http://usa.autodesk.com/adsk/servlet/pc/item?siteID=123112&id=24314456