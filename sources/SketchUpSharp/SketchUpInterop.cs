using System;
using System.Runtime.InteropServices;

namespace SketchUpSharp
{
    public partial struct SUPoint3D
    {
    }

    public partial struct SUPoint3D
    {
    }

    public partial struct SUPoint3D
    {
        public double x;

        public double y;

        public double z;
    }

    public partial struct SUVector3D
    {
    }

    public partial struct SUVector3D
    {
    }

    public partial struct SUVector3D
    {
        public double x;

        public double y;

        public double z;
    }

    public enum SUArrowType
    {
        SUArrowNone = 0,
        SUArrowSlash,
        SUArrowDot,
        SUArrowClosed,
        SUArrowOpen,
    }

    public partial struct SUComponentBehavior
    {
        [NativeTypeName("enum SUSnapToBehavior")]
        public SUSnapToBehavior component_snap;

        public bool component_cuts_opening;

        public bool component_always_face_camera;

        public bool component_shadows_face_sun;

        [NativeTypeName("size_t")]
        public nuint component_no_scale_mask;

        public enum SUSnapToBehavior
        {
            SUSnapToBehavior_None = 0,
            SUSnapToBehavior_Any,
            SUSnapToBehavior_Horizontal,
            SUSnapToBehavior_Vertical,
            SUSnapToBehavior_Sloped,
        }
    }

    public enum SUComponentType
    {
        SUComponentType_Normal,
        SUComponentType_Group,
    }

    public enum SUCurveType
    {
        SUCurveType_Simple = 0,
        SUCurveType_Arc,
    }

    public unsafe partial struct SUArcCurveRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUAttributeDictionaryRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUAxesRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUCameraRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUClassificationsRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUClassificationAttributeRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUClassificationInfoRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUComponentDefinitionRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUComponentInstanceRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUCurveRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDimensionRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDimensionLinearRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDimensionRadialRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDimensionStyleRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDrawingElementRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDynamicComponentInfoRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUDynamicComponentAttributeRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEdgeRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEdgeUseRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEntitiesRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEntityListRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEntityListIteratorRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUEntityRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUFaceRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUFontRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUGeometryInputRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUGroupRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUGuideLineRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUGuidePointRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUImageRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUImageRepRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUInstancePathRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULayerRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULayerFolderRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULineStyleRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULineStylesRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULocationRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULoopInputRef
    {
        public void* ptr;
    }

    public unsafe partial struct SULoopRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUMaterialRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUMeshHelperRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUModelRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUOpeningRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUOptionsManagerRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUOptionsProviderRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUPolyline3dRef
    {
        public void* ptr;
    }

    public unsafe partial struct SURenderingOptionsRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUSceneRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUSchemaRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUSchemaTypeRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUSectionPlaneRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUSelectionRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUShadowInfoRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUStyleRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUStylesRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUTextRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUTextureRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUTextureWriterRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUTypedValueRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUUVHelperRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUVertexRef
    {
        public void* ptr;
    }

    public enum SURefType
    {
        SURefType_Unknown = 0,
        SURefType_AttributeDictionary,
        SURefType_Camera,
        SURefType_ComponentDefinition,
        SURefType_ComponentInstance,
        SURefType_Curve,
        SURefType_Edge,
        SURefType_EdgeUse,
        SURefType_Entities,
        SURefType_Face,
        SURefType_Group,
        SURefType_Image,
        SURefType_Layer,
        SURefType_Location,
        SURefType_Loop,
        SURefType_MeshHelper,
        SURefType_Material,
        SURefType_Model,
        SURefType_Polyline3D,
        SURefType_Scene,
        SURefType_Texture,
        SURefType_TextureWriter,
        SURefType_TypedValue,
        SURefType_UVHelper,
        SURefType_Vertex,
        SURefType_RenderingOptions,
        SURefType_GuidePoint,
        SURefType_GuideLine,
        SURefType_Schema,
        SURefType_SchemaType,
        SURefType_ShadowInfo,
        SURefType_Axes,
        SURefType_ArcCurve,
        SURefType_SectionPlane,
        SURefType_DynamicComponentInfo,
        SURefType_DynamicComponentAttribute,
        SURefType_Style,
        SURefType_Styles,
        SURefType_ImageRep,
        SURefType_InstancePath,
        SURefType_Font,
        SURefType_Dimension,
        SURefType_DimensionLinear,
        SURefType_DimensionRadial,
        SURefType_DimensionStyle,
        SURefType_Text,
        SURefType_EntityList,
        SURefType_EntityListIterator,
        SURefType_DrawingElement,
        SURefType_Entity,
        SURefType_LengthFormatter,
        SURefType_LineStyle,
        SURefType_LineStyleManager,
        SURefType_Selection,
        SURefType_LayerFolder,
    }

    public enum SUDimensionType
    {
        SUDimensionType_Invalid = 0,
        SUDimensionType_Linear,
        SUDimensionType_Radial,
    }

    public enum SUHorizontalTextPositionType
    {
        SUHorizontalTextPositionCenter = 0,
        SUHorizontalTextPositionOutsideStart,
        SUHorizontalTextPositionOutsideEnd,
    }

    public enum SUVerticalTextPositionType
    {
        SUVerticalTextPositionCenter = 0,
        SUVerticalTextPositionAbove,
        SUVerticalTextPositionBelow,
    }

    public enum SUDimensionLinearAlignmentType
    {
        SUDimensionLinearAlignmentAligned = 0,
        SUDimensionLinearAlignmentVertical,
        SUDimensionLinearAlignmentHorizontal,
    }

    public partial struct SUBoundingBox3D
    {
    }

    public partial struct SUBoundingBox3D
    {
        [NativeTypeName("struct SUPoint3D")]
        public SUPoint3D min_point;

        [NativeTypeName("struct SUPoint3D")]
        public SUPoint3D max_point;
    }

    public partial struct SUMaterialInput
    {
        [NativeTypeName("size_t")]
        public nuint num_uv_coords;

        [NativeTypeName("struct SUPoint2D[4]")]
        public _uv_coords_e__FixedBuffer uv_coords;

        [NativeTypeName("size_t[4]")]
        public _vertex_indices_e__FixedBuffer vertex_indices;

        public SUMaterialRef material;

        public partial struct _uv_coords_e__FixedBuffer
        {
            public SUPoint2D e0;
            public SUPoint2D e1;
            public SUPoint2D e2;
            public SUPoint2D e3;

            public ref SUPoint2D this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<SUPoint2D> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }

        public partial struct _vertex_indices_e__FixedBuffer
        {
            public nuint e0;
            public nuint e1;
            public nuint e2;
            public nuint e3;

            public ref nuint this[int index]
            {
                get
                {
                    return ref AsSpan()[index];
                }
            }

            public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
        }
    }

    public partial struct SUColorOrder
    {
        public short red_index;

        public short green_index;

        public short blue_index;

        public short alpha_index;
    }

    public enum SULayerVisibilityDefaultType
    {
        SULayerVisibilityDefaultType_Visible = 0x0000,
        SULayerVisibilityDefaultType_Hidden = 0x0001,
    }

    public enum SULayerVisibilityNewSceneType
    {
        SULayerVisibilityNewSceneType_LayerDefault = 0x0000,
        SULayerVisibilityNewSceneType_Visible = 0x0010,
        SULayerVisibilityNewSceneType_Hidden = 0x0020,
    }

    public enum SULoopWinding
    {
        SULoopWinding_CCW,
        SULoopWinding_CW,
    }

    public enum SUMaterialType
    {
        SUMaterialType_Colored = 0,
        SUMaterialType_Textured,
        SUMaterialType_ColorizedTexture,
    }

    public enum SUMaterialOwnerType
    {
        SUMaterialOwnerType_None = 0,
        SUMaterialOwnerType_DrawingElement,
        SUMaterialOwnerType_Image,
        SUMaterialOwnerType_Layer,
    }

    public enum SUMaterialColorizeType
    {
        SUMaterialColorizeType_Shift = 0,
        SUMaterialColorizeType_Tint,
    }

    public unsafe partial struct SUModelStatistics
    {
        [NativeTypeName("int[8]")]
        public fixed int entity_counts[8];

        public enum SUEntityType
        {
            SUEntityType_Edge = 0,
            SUEntityType_Face,
            SUEntityType_ComponentInstance,
            SUEntityType_Group,
            SUEntityType_Image,
            SUEntityType_ComponentDefinition,
            SUEntityType_Layer,
            SUEntityType_Material,
            SUNumEntityTypes,
        }
    }

    public enum SUModelUnits
    {
        SUModelUnits_Inches,
        SUModelUnits_Feet,
        SUModelUnits_Millimeters,
        SUModelUnits_Centimeters,
        SUModelUnits_Meters,
    }

    public enum SUModelVersion
    {
        SUModelVersion_SU3,
        SUModelVersion_SU4,
        SUModelVersion_SU5,
        SUModelVersion_SU6,
        SUModelVersion_SU7,
        SUModelVersion_SU8,
        SUModelVersion_SU2013,
        SUModelVersion_SU2014,
        SUModelVersion_SU2015,
        SUModelVersion_SU2016,
        SUModelVersion_SU2017,
        SUModelVersion_SU2018,
        SUModelVersion_SU2019,
        SUModelVersion_SU2020,
        SUModelVersion_SU2021,
    }

    public enum SUModelLoadStatus
    {
        SUModelLoadStatus_Success = 0,
        SUModelLoadStatus_Success_MoreRecent,
    }

    public enum SUSelectionType
    {
        SUSelectionType_Curve,
        SUSelectionType_Surface,
        SUSelectionType_SingleObject,
    }

    public enum SUStylePropertyType
    {
        SUStyleEdgesColor = 0,
        SUStyleEdgesExtensionsEnabled = 1,
        SUStyleEdgesExtensionLength = 2,
        SUStyleEdgesProfilesEnabled = 3,
        SUStyleEdgesProfileWidth = 4,
        SUStyleEdgesDepthCueEnabled = 5,
        SUStyleEdgesDepthCueLevels = 6,
        SUStyleBackgroundColor = 64,
    }

    public enum SUTextLeaderType
    {
        SUTextLeaderType_None = 0,
        SUTextLeaderType_ViewBased,
        SUTextLeaderType_PushPin,
    }

    public enum SUTypedValueType
    {
        SUTypedValueType_Empty = 0,
        SUTypedValueType_Byte,
        SUTypedValueType_Short,
        SUTypedValueType_Int32,
        SUTypedValueType_Float,
        SUTypedValueType_Double,
        SUTypedValueType_Bool,
        SUTypedValueType_Color,
        SUTypedValueType_Time,
        SUTypedValueType_String,
        SUTypedValueType_Vector3D,
        SUTypedValueType_Array,
    }

    public partial struct SUUVQ
    {
        public double u;

        public double v;

        public double q;
    }

    public partial struct SUColor
    {
        [NativeTypeName("SUByte")]
        public byte red;

        [NativeTypeName("SUByte")]
        public byte green;

        [NativeTypeName("SUByte")]
        public byte blue;

        [NativeTypeName("SUByte")]
        public byte alpha;
    }

    public enum SUResult
    {
        SU_ERROR_NONE = 0,
        SU_ERROR_NULL_POINTER_INPUT,
        SU_ERROR_INVALID_INPUT,
        SU_ERROR_NULL_POINTER_OUTPUT,
        SU_ERROR_INVALID_OUTPUT,
        SU_ERROR_OVERWRITE_VALID,
        SU_ERROR_GENERIC,
        SU_ERROR_SERIALIZATION,
        SU_ERROR_OUT_OF_RANGE,
        SU_ERROR_NO_DATA,
        SU_ERROR_INSUFFICIENT_SIZE,
        SU_ERROR_UNKNOWN_EXCEPTION,
        SU_ERROR_MODEL_INVALID,
        SU_ERROR_MODEL_VERSION,
        SU_ERROR_LAYER_LOCKED,
        SU_ERROR_DUPLICATE,
        SU_ERROR_PARTIAL_SUCCESS,
        SU_ERROR_UNSUPPORTED,
        SU_ERROR_INVALID_ARGUMENT,
        SU_ERROR_ENTITY_LOCKED,
        SU_ERROR_INVALID_OPERATION,
    }

    public unsafe partial struct SULengthFormatterRef
    {
        public void* ptr;
    }

    public unsafe partial struct SUStringRef
    {
        public void* ptr;
    }

    public enum SUExtensionLicenseState
    {
        SUExtensionLicenseState_Licensed,
        SUExtensionLicenseState_Expired,
        SUExtensionLicenseState_Trial,
        SUExtensionLicenseState_TrialExpired,
        SUExtensionLicenseState_NotLicensed,
    }

    public unsafe partial struct SUExtensionLicense
    {
        public bool is_licensed;

        [NativeTypeName("enum SUExtensionLicenseState")]
        public SUExtensionLicenseState state;

        [NativeTypeName("size_t")]
        public nuint days_remaining;

        [NativeTypeName("char[512]")]
        public fixed sbyte error_description[512];
    }

    public partial struct SUPoint2D
    {
        public double x;

        public double y;
    }

    public partial struct SUVector2D
    {
        public double x;

        public double y;
    }

    public partial struct SUPlane3D
    {
        public double a;

        public double b;

        public double c;

        public double d;
    }

    public partial struct SUAxisAlignedRect2D
    {
        [NativeTypeName("struct SUPoint2D")]
        public SUPoint2D upper_left;

        [NativeTypeName("struct SUPoint2D")]
        public SUPoint2D lower_right;
    }

    public partial struct SURay3D
    {
        [NativeTypeName("struct SUPoint3D")]
        public SUPoint3D point;

        [NativeTypeName("struct SUVector3D")]
        public SUVector3D normal;
    }

    public unsafe partial struct SUTransformation
    {
        [NativeTypeName("double[16]")]
        public fixed double values[16];
    }

    public partial struct SUTransformation2D
    {
        public double m11;

        public double m12;

        public double m21;

        public double m22;

        public double tx;

        public double ty;
    }

    public enum SULengthFormatType
    {
        SU_LFORMAT_DECIMAL,
        SU_LFORMAT_ARCHITECTURAL,
        SU_LFORMAT_ENGINEERING,
        SU_LFORMAT_FRACTIONAL,
    }

    public enum SULengthUnitType
    {
        SU_LUNIT_INCHES,
        SU_LUNIT_FEET,
        SU_LUNIT_MILLIMETER,
        SU_LUNIT_CENTIMETER,
        SU_LUNIT_METER,
        SU_LUNIT_YARD,
    }

    public enum SUAreaUnitType
    {
        SU_AUNIT_SQUARE_INCHES,
        SU_AUNIT_SQUARE_FEET,
        SU_AUNIT_SQUARE_MILLIMETER,
        SU_AUNIT_SQUARE_CENTIMETER,
        SU_AUNIT_SQUARE_METER,
        SU_AUNIT_SQUARE_YARD,
    }

    public enum SUVolumeUnitType
    {
        SU_VUNIT_CUBIC_INCHES,
        SU_VUNIT_CUBIC_FEET,
        SU_VUNIT_CUBIC_MILLIMETER,
        SU_VUNIT_CUBIC_CENTIMETER,
        SU_VUNIT_CUBIC_METER,
        SU_VUNIT_CUBIC_YARD,
        SU_VUNIT_LITER,
        SU_VUNIT_US_GALLON,
    }

    public static unsafe partial class Methods
    {
        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUBoundingBox3DGetMidPoint([NativeTypeName("const struct SUBoundingBox3D *")] SUBoundingBox3D* bounding_box, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* mid_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DSetWithPoints([NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point1, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point2, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point3);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DSetWithPointAndNormal([NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DSetWithCoefficients([NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane, double a, double b, double c, double d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DGetPosition([NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DGetNormal([NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DIsOn([NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, bool* is_on);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DDistanceTo([NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, double* distance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DProjectTo([NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* projected_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPlane3DTransform([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint2DToSUPoint2D([NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point1, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point2, [NativeTypeName("struct SUVector2D *")] SUVector2D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint2DGetEqual([NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point1, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point2, bool* equal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint2DOffset([NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector, [NativeTypeName("struct SUPoint2D *")] SUPoint2D* point2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint2DDistanceToSUPoint2D([NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point1, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point2, double* distance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint2DTransform([NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("struct SUPoint2D *")] SUPoint2D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint3DGetEqual([NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point1, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point2, bool* equal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint3DLessThan([NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point1, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point2, bool* less_than);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint3DOffset([NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint3DDistanceToSUPoint3D([NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point1, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point2, double* distance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPoint3DTransform([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURay3DIsOn([NativeTypeName("const struct SURay3D *")] SURay3D* ray, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, bool* is_on);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURay3DDistanceTo([NativeTypeName("const struct SURay3D *")] SURay3D* ray, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, double* distance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURay3DProjectTo([NativeTypeName("const struct SURay3D *")] SURay3D* ray, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* projected_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationSetFromPointAndNormal([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationSetFromPointAndAxes([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* x_axis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* y_axis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* z_axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationTranslation([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationScale([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, double scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationNonUniformScale([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, double x_scale, double y_scale, double z_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationScaleAboutPoint([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, double scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationNonUniformScaleAboutPoint([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, double x_scale, double y_scale, double z_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationRotation([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector, double angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationInterpolate([NativeTypeName("struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("const struct SUTransformation *")] SUTransformation* t1, [NativeTypeName("const struct SUTransformation *")] SUTransformation* t2, double weight);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationIsIdentity([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, bool* is_identity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetInverse([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUTransformation *")] SUTransformation* inverse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetOrigin([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* origin);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetXAxis([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUVector3D *")] SUVector3D* x_axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetYAxis([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUVector3D *")] SUVector3D* y_axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetZAxis([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUVector3D *")] SUVector3D* z_axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationGetZRotation([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, double* z_rotation);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationMultiply([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform1, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform2, [NativeTypeName("struct SUTransformation *")] SUTransformation* out_transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformationIsMirrored([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, bool* is_mirrored);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DTranslation([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DScale([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, double scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DNonUniformScale([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, double x_scale, double y_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DScaleAboutPoint([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point, double scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DNonUniformScaleAboutPoint([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point, double x_scale, double y_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DRotation([NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* point, double angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DIsIdentity([NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform, bool* is_identity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DGetInverse([NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* inverse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTransformation2DMultiply([NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform1, [NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform2, [NativeTypeName("struct SUTransformation2D *")] SUTransformation2D* out_transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DCreate([NativeTypeName("struct SUVector2D *")] SUVector2D* vector, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* from, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* to);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsValid([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector, bool* valid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsParallelTo([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, bool* parallel);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsPerpendicularTo([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, bool* perpendicular);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsSameDirectionAs([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, bool* same_direction);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsEqual([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, bool* equal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DNormalize([NativeTypeName("struct SUVector2D *")] SUVector2D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DReverse([NativeTypeName("struct SUVector2D *")] SUVector2D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DDot([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, double* dot);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DCross([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, double* cross);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DIsUnitVector([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector, bool* is_unit_vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DGetLength([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector, double* length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DSetLength([NativeTypeName("struct SUVector2D *")] SUVector2D* vector, double length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DAngleBetween([NativeTypeName("const struct SUVector2D *")] SUVector2D* vector1, [NativeTypeName("const struct SUVector2D *")] SUVector2D* vector2, double* angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector2DTransform([NativeTypeName("const struct SUTransformation2D *")] SUTransformation2D* transform, [NativeTypeName("struct SUVector2D *")] SUVector2D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DCreate([NativeTypeName("struct SUVector3D *")] SUVector3D* vector, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* from, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* to);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsValid([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector, bool* valid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsParallelTo([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, bool* parallel);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsPerpendicularTo([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, bool* perpendicular);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsSameDirectionAs([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, bool* same_direction);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsEqual([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, bool* equal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DLessThan([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, bool* less_than);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DNormalize([NativeTypeName("struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DReverse([NativeTypeName("struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DDot([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, double* dot);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DCross([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, [NativeTypeName("struct SUVector3D *")] SUVector3D* cross);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DIsUnitVector([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector, bool* is_unit_vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DGetLength([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector, double* length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DSetLength([NativeTypeName("struct SUVector3D *")] SUVector3D* vector, double length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DAngleBetween([NativeTypeName("const struct SUVector3D *")] SUVector3D* vector1, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector2, double* angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DGetArbitraryAxes([NativeTypeName("const struct SUVector3D *")] SUVector3D* z_axis, [NativeTypeName("struct SUVector3D *")] SUVector3D* x_axis, [NativeTypeName("struct SUVector3D *")] SUVector3D* y_axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DTransform([NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, [NativeTypeName("struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVector3DLinearCombination([NativeTypeName("const struct SUVector3D *")] SUVector3D* vectors, [NativeTypeName("const double *")] double* weights, [NativeTypeName("const size_t")] nuint size, [NativeTypeName("struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUArcCurveToEntity(SUArcCurveRef arccurve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUArcCurveRef SUArcCurveFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUCurveRef SUArcCurveToCurve(SUArcCurveRef arccurve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUArcCurveRef SUArcCurveFromCurve(SUCurveRef curve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveCreate(SUArcCurveRef* arccurve, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* center, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* start_point, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* end_point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* normal, [NativeTypeName("size_t")] nuint num_edges);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveRelease(SUArcCurveRef* arccurve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetRadius(SUArcCurveRef arccurve, double* radius);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetStartPoint(SUArcCurveRef arccurve, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetEndPoint(SUArcCurveRef arccurve, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetXAxis(SUArcCurveRef arccurve, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetYAxis(SUArcCurveRef arccurve, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetCenter(SUArcCurveRef arccurve, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetNormal(SUArcCurveRef arccurve, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetStartAngle(SUArcCurveRef arccurve, double* angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetEndAngle(SUArcCurveRef arccurve, double* angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUArcCurveGetIsFullCircle(SUArcCurveRef arccurve, bool* is_full);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryCreate(SUAttributeDictionaryRef* dictionary, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryRelease(SUAttributeDictionaryRef* dictionary);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUAttributeDictionaryToEntity(SUAttributeDictionaryRef dictionary);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUAttributeDictionaryRef SUAttributeDictionaryFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryGetName(SUAttributeDictionaryRef dictionary, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionarySetValue(SUAttributeDictionaryRef dictionary, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef value_in);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryGetValue(SUAttributeDictionaryRef dictionary, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef* value_out);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryGetNumKeys(SUAttributeDictionaryRef dictionary, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAttributeDictionaryGetKeys(SUAttributeDictionaryRef dictionary, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* keys, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUAxesToEntity(SUAxesRef axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUAxesRef SUAxesFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUAxesToDrawingElement(SUAxesRef axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUAxesRef SUAxesFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesCreate(SUAxesRef* axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesCreateCustom(SUAxesRef* axes, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* origin, [NativeTypeName("const struct SUVector3D *")] SUVector3D* xaxis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* yaxis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* zaxis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesRelease(SUAxesRef* axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetOrigin(SUAxesRef axes, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* origin);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesSetOrigin(SUAxesRef axes, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* origin);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetXAxis(SUAxesRef axes, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetYAxis(SUAxesRef axes, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetZAxis(SUAxesRef axes, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesSetAxesVecs(SUAxesRef axes, [NativeTypeName("const struct SUVector3D *")] SUVector3D* xaxis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* yaxis, [NativeTypeName("const struct SUVector3D *")] SUVector3D* zaxis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetTransform(SUAxesRef axes, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUAxesGetPlane(SUAxesRef axes, [NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraCreate(SUCameraRef* camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraRelease(SUCameraRef* camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetOrientation(SUCameraRef camera, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* target, [NativeTypeName("struct SUVector3D *")] SUVector3D* up_vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetOrientation(SUCameraRef camera, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* position, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* target, [NativeTypeName("const struct SUVector3D *")] SUVector3D* up_vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetViewTransformation(SUCameraRef camera, [NativeTypeName("struct SUTransformation *")] SUTransformation* transformation);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetPerspectiveFrustumFOV(SUCameraRef camera, double fov);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetPerspectiveFrustumFOV(SUCameraRef camera, double* fov);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetAspectRatio(SUCameraRef camera, double aspect_ratio);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetAspectRatio(SUCameraRef camera, double* aspect_ratio);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetOrthographicFrustumHeight(SUCameraRef camera, double height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetOrthographicFrustumHeight(SUCameraRef camera, double* height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetPerspective(SUCameraRef camera, [NativeTypeName("bool")] byte perspective);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetPerspective(SUCameraRef camera, bool* perspective);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetClippingDistances(SUCameraRef camera, double* znear, double* zfar);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetFOVIsHeight(SUCameraRef camera, [NativeTypeName("bool")] byte is_fov_height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetFOVIsHeight(SUCameraRef camera, bool* is_fov_height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetImageWidth(SUCameraRef camera, double width);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetImageWidth(SUCameraRef camera, double* width);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetDescription(SUCameraRef camera, [NativeTypeName("const char *")] sbyte* desc);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetDescription(SUCameraRef camera, SUStringRef* desc);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetDirection(SUCameraRef camera, [NativeTypeName("struct SUVector3D *")] SUVector3D* direction);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSet2D(SUCameraRef camera, [NativeTypeName("bool")] byte make_2d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGet2D(SUCameraRef camera, bool* is_2d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetScale2D(SUCameraRef camera, double scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetScale2D(SUCameraRef camera, double* scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraSetCenter2D(SUCameraRef camera, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* center);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCameraGetCenter2D(SUCameraRef camera, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* center);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationsLoadSchema(SUClassificationsRef classifications, [NativeTypeName("const char *")] sbyte* schema_file_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationsGetSchema(SUClassificationsRef classifications, [NativeTypeName("const char *")] sbyte* schema_name, SUSchemaRef* schema_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationAttributeGetValue(SUClassificationAttributeRef attribute, SUTypedValueRef* value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationAttributeGetPath(SUClassificationAttributeRef attribute, SUStringRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationAttributeGetNumChildren(SUClassificationAttributeRef attribute, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationAttributeGetChild(SUClassificationAttributeRef attribute, [NativeTypeName("size_t")] nuint index, SUClassificationAttributeRef* child);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoRelease(SUClassificationInfoRef* classification_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoGetNumSchemas(SUClassificationInfoRef classification_info, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoGetSchemaName(SUClassificationInfoRef classification_info, [NativeTypeName("size_t")] nuint index, SUStringRef* schema_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoGetSchemaType(SUClassificationInfoRef classification_info, [NativeTypeName("size_t")] nuint index, SUStringRef* schema_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoGetSchemaAttribute(SUClassificationInfoRef classification_info, [NativeTypeName("size_t")] nuint index, SUClassificationAttributeRef* attribute);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUClassificationInfoGetSchemaAttributeByPath(SUClassificationInfoRef classification_info, SUStringRef path, SUClassificationAttributeRef* attribute);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUComponentDefinitionToEntity(SUComponentDefinitionRef comp_def);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUComponentDefinitionRef SUComponentDefinitionFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUComponentDefinitionToDrawingElement(SUComponentDefinitionRef comp_def);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUComponentDefinitionRef SUComponentDefinitionFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionCreate(SUComponentDefinitionRef* comp_def);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionRelease(SUComponentDefinitionRef* comp_def);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetName(SUComponentDefinitionRef comp_def, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionSetName(SUComponentDefinitionRef comp_def, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetGuid(SUComponentDefinitionRef comp_def, SUStringRef* guid_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetEntities(SUComponentDefinitionRef comp_def, SUEntitiesRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetDescription(SUComponentDefinitionRef comp_def, SUStringRef* desc);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionSetDescription(SUComponentDefinitionRef comp_def, [NativeTypeName("const char *")] sbyte* desc);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionCreateInstance(SUComponentDefinitionRef comp_def, SUComponentInstanceRef* instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetNumUsedInstances(SUComponentDefinitionRef comp_def, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetNumInstances(SUComponentDefinitionRef comp_def, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetInstances(SUComponentDefinitionRef comp_def, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentInstanceRef[]")] SUComponentInstanceRef* instances, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetBehavior(SUComponentDefinitionRef comp_def, [NativeTypeName("struct SUComponentBehavior *")] SUComponentBehavior* behavior);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionSetBehavior(SUComponentDefinitionRef comp_def, [NativeTypeName("const struct SUComponentBehavior *")] SUComponentBehavior* behavior);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionApplySchemaType(SUComponentDefinitionRef comp_def, SUSchemaRef schema_ref, SUSchemaTypeRef schema_type_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionIsInternal(SUComponentDefinitionRef comp_def, bool* is_internal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetPath(SUComponentDefinitionRef comp_def, SUStringRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetLoadTime(SUComponentDefinitionRef comp_def, [NativeTypeName("struct tm *")] tm* load_time);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetNumOpenings(SUComponentDefinitionRef comp_def, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetOpenings(SUComponentDefinitionRef comp_def, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUOpeningRef[]")] SUOpeningRef* openings, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetInsertPoint(SUComponentDefinitionRef comp_def, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionGetType(SUComponentDefinitionRef comp_def, [NativeTypeName("enum SUComponentType *")] SUComponentType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionOrientFacesConsistently(SUComponentDefinitionRef comp_def);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionSetInsertPoint(SUComponentDefinitionRef comp_def, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionSetAxes(SUComponentDefinitionRef comp_def, SUAxesRef axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentDefinitionIsLiveComponent(SUComponentDefinitionRef comp_def, bool* is_live);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUComponentInstanceToEntity(SUComponentInstanceRef instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUComponentInstanceRef SUComponentInstanceFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUComponentInstanceToDrawingElement(SUComponentInstanceRef instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUComponentInstanceRef SUComponentInstanceFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceSetName(SUComponentInstanceRef instance, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceRelease(SUComponentInstanceRef* instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetName(SUComponentInstanceRef instance, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceSetGuid(SUComponentInstanceRef instance, [NativeTypeName("const char *")] sbyte* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetGuid(SUComponentInstanceRef instance, SUStringRef* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceSetTransform(SUComponentInstanceRef instance, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetTransform(SUComponentInstanceRef instance, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetDefinition(SUComponentInstanceRef instance, SUComponentDefinitionRef* component);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceSetLocked(SUComponentInstanceRef instance, [NativeTypeName("bool")] byte @lock);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceIsLocked(SUComponentInstanceRef instance, bool* is_locked);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceSaveAs(SUComponentInstanceRef instance, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceComputeVolume(SUComponentInstanceRef instance, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, double* volume);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceCreateDCInfo(SUComponentInstanceRef instance, SUDynamicComponentInfoRef* dc_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceCreateClassificationInfo(SUComponentInstanceRef instance, SUClassificationInfoRef* classification_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetNumAttachedInstances(SUComponentInstanceRef instance, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetAttachedInstances(SUComponentInstanceRef instance, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentInstanceRef[]")] SUComponentInstanceRef* instances, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetNumAttachedToDrawingElements(SUComponentInstanceRef instance, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUComponentInstanceGetAttachedToDrawingElements(SUComponentInstanceRef instance, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUDrawingElementRef[]")] SUDrawingElementRef* elements, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUCurveToEntity(SUCurveRef curve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUCurveRef SUCurveFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCurveCreateWithEdges(SUCurveRef* curve, [NativeTypeName("const SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t")] nuint len);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCurveRelease(SUCurveRef* curve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCurveGetType(SUCurveRef curve, [NativeTypeName("enum SUCurveType *")] SUCurveType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCurveGetNumEdges(SUCurveRef curve, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUCurveGetEdges(SUCurveRef curve, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUDimensionToEntity(SUDimensionRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionRef SUDimensionFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUDimensionToDrawingElement(SUDimensionRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionRef SUDimensionFromDrawingElement(SUDrawingElementRef element);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetType(SUDimensionRef dimension, [NativeTypeName("enum SUDimensionType *")] SUDimensionType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetText(SUDimensionRef dimension, SUStringRef* text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionSetText(SUDimensionRef dimension, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetPlane(SUDimensionRef dimension, [NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetText3D(SUDimensionRef dimension, bool* is_text_3d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionSetText3D(SUDimensionRef dimension, [NativeTypeName("bool")] byte is_text_3d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetArrowType(SUDimensionRef dimension, [NativeTypeName("enum SUArrowType *")] SUArrowType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionSetArrowType(SUDimensionRef dimension, [NativeTypeName("enum SUArrowType")] SUArrowType type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionGetFont(SUDimensionRef dimension, SUFontRef* font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionSetFont(SUDimensionRef dimension, SUFontRef font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionRef SUDimensionLinearToDimension(SUDimensionLinearRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionLinearRef SUDimensionLinearFromDimension(SUDimensionRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearCreate(SUDimensionLinearRef* dimension, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* start_point, SUInstancePathRef start_path, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* end_point, SUInstancePathRef end_path, double offset);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearRelease(SUDimensionLinearRef* dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetStartPoint(SUDimensionLinearRef dimension, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetStartPoint(SUDimensionLinearRef dimension, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetEndPoint(SUDimensionLinearRef dimension, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetEndPoint(SUDimensionLinearRef dimension, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetXAxis(SUDimensionLinearRef dimension, [NativeTypeName("struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetXAxis(SUDimensionLinearRef dimension, [NativeTypeName("const struct SUVector3D *")] SUVector3D* axis);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetNormal(SUDimensionLinearRef dimension, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetNormal(SUDimensionLinearRef dimension, [NativeTypeName("const struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetPosition(SUDimensionLinearRef dimension, [NativeTypeName("struct SUPoint2D *")] SUPoint2D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetPosition(SUDimensionLinearRef dimension, [NativeTypeName("const struct SUPoint2D *")] SUPoint2D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetVerticalAlignment(SUDimensionLinearRef dimension, [NativeTypeName("enum SUVerticalTextPositionType *")] SUVerticalTextPositionType* alignment);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetVerticalAlignment(SUDimensionLinearRef dimension, [NativeTypeName("enum SUVerticalTextPositionType")] SUVerticalTextPositionType alignment);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetHorizontalAlignment(SUDimensionLinearRef dimension, [NativeTypeName("enum SUHorizontalTextPositionType *")] SUHorizontalTextPositionType* alignment);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearSetHorizontalAlignment(SUDimensionLinearRef dimension, [NativeTypeName("enum SUHorizontalTextPositionType")] SUHorizontalTextPositionType alignment);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetAlignment(SUDimensionLinearRef dimension, [NativeTypeName("enum SUDimensionLinearAlignmentType *")] SUDimensionLinearAlignmentType* alignment);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionLinearGetTextPosition(SUDimensionLinearRef dimension, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionRef SUDimensionRadialToDimension(SUDimensionRadialRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDimensionRadialRef SUDimensionRadialFromDimension(SUDimensionRef dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialCreate(SUDimensionRadialRef* dimension, SUInstancePathRef path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialRelease(SUDimensionRadialRef* dimension);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialGetCurveInstancePath(SUDimensionRadialRef dimension, SUInstancePathRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialSetCurveInstancePath(SUDimensionRadialRef dimension, SUInstancePathRef path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialGetDiameter(SUDimensionRadialRef dimension, bool* is_diameter);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialSetDiameter(SUDimensionRadialRef dimension, [NativeTypeName("bool")] byte is_diameter);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialGetLeaderBreakPoint(SUDimensionRadialRef dimension, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialSetLeaderBreakPoint(SUDimensionRadialRef dimension, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionRadialGetLeaderPoints(SUDimensionRadialRef dimension, [NativeTypeName("struct SUPoint3D[3]")] SUPoint3D* points);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetFont(SUDimensionStyleRef style, SUFontRef* font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGet3D(SUDimensionStyleRef style, bool* has_3d);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetArrowType(SUDimensionStyleRef style, [NativeTypeName("enum SUArrowType *")] SUArrowType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetArrowSize(SUDimensionStyleRef style, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetColor(SUDimensionStyleRef style, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetTextColor(SUDimensionStyleRef style, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetExtensionLineOffset(SUDimensionStyleRef style, [NativeTypeName("size_t *")] nuint* offset);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetExtensionLineOvershoot(SUDimensionStyleRef style, [NativeTypeName("size_t *")] nuint* overshoot);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetLineWeight(SUDimensionStyleRef style, [NativeTypeName("size_t *")] nuint* weight);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHighlightNonAssociativeDimensions(SUDimensionStyleRef style, bool* highlight);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHighlightNonAssociativeDimensionsColor(SUDimensionStyleRef style, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetShowRadialPrefix(SUDimensionStyleRef style, bool* show);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHideOutOfPlane(SUDimensionStyleRef style, bool* hide);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHideOutOfPlaneValue(SUDimensionStyleRef style, double* tolerance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHideSmall(SUDimensionStyleRef style, bool* hide);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDimensionStyleGetHideSmallValue(SUDimensionStyleRef style, double* tolerance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUDrawingElementToEntity(SUDrawingElementRef elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUDrawingElementFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SURefType")]
        public static extern SURefType SUDrawingElementGetType(SUDrawingElementRef elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetBoundingBox(SUDrawingElementRef elem, [NativeTypeName("struct SUBoundingBox3D *")] SUBoundingBox3D* bbox);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetMaterial(SUDrawingElementRef elem, SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementSetMaterial(SUDrawingElementRef elem, SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetLayer(SUDrawingElementRef elem, SULayerRef* layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementSetLayer(SUDrawingElementRef elem, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementSetHidden(SUDrawingElementRef elem, [NativeTypeName("bool")] byte hide_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetHidden(SUDrawingElementRef elem, bool* hide_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementSetCastsShadows(SUDrawingElementRef elem, [NativeTypeName("bool")] byte casts_shadows_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetCastsShadows(SUDrawingElementRef elem, bool* casts_shadows_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementSetReceivesShadows(SUDrawingElementRef elem, [NativeTypeName("bool")] byte receives_shadows_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDrawingElementGetReceivesShadows(SUDrawingElementRef elem, bool* receives_shadows_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentAttributeGetName(SUDynamicComponentAttributeRef attribute, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentAttributeGetDisplayName(SUDynamicComponentAttributeRef attribute, SUStringRef* display_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentAttributeGetVisibility(SUDynamicComponentAttributeRef attribute, bool* visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentAttributeGetDisplayValue(SUDynamicComponentAttributeRef attribute, SUStringRef* display_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentInfoRelease(SUDynamicComponentInfoRef* dc_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentInfoGetNumDCAttributes(SUDynamicComponentInfoRef dc_info, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUDynamicComponentInfoGetDCAttributes(SUDynamicComponentInfoRef dc_info, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUDynamicComponentAttributeRef[]")] SUDynamicComponentAttributeRef* attributes, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUEdgeToEntity(SUEdgeRef edge);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEdgeRef SUEdgeFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUEdgeToDrawingElement(SUEdgeRef edge);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEdgeRef SUEdgeFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeCreate(SUEdgeRef* edge, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* start, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* end);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeRelease(SUEdgeRef* edge);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetCurve(SUEdgeRef edge, SUCurveRef* curve);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetStartVertex(SUEdgeRef edge, SUVertexRef* vertex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetEndVertex(SUEdgeRef edge, SUVertexRef* vertex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeSetSoft(SUEdgeRef edge, [NativeTypeName("bool")] byte soft_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetSoft(SUEdgeRef edge, bool* soft_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeSetSmooth(SUEdgeRef edge, [NativeTypeName("bool")] byte smooth_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetSmooth(SUEdgeRef edge, bool* smooth_flag);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetNumFaces(SUEdgeRef edge, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetFaces(SUEdgeRef edge, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUFaceRef[]")] SUFaceRef* faces, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetColor(SUEdgeRef edge, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeGetLengthWithTransform(SUEdgeRef edge, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, double* length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeSetColor(SUEdgeRef edge, [NativeTypeName("const SUColor *")] SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUEdgeUseToEntity(SUEdgeUseRef edgeuse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEdgeUseRef SUEdgeUseFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetEdge(SUEdgeUseRef edgeuse, SUEdgeRef* edge);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetLoop(SUEdgeUseRef edgeuse, SULoopRef* loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetFace(SUEdgeUseRef edgeuse, SUFaceRef* face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetNumPartners(SUEdgeUseRef edgeuse, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetPartners(SUEdgeUseRef edgeuse, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeUseRef[]")] SUEdgeUseRef* partners, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseIsReversed(SUEdgeUseRef edgeuse, bool* reversed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetPrevious(SUEdgeUseRef edgeuse, SUEdgeUseRef* prev_edgeuse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetNext(SUEdgeUseRef edgeuse, SUEdgeUseRef* next_edgeuse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetStartVertex(SUEdgeUseRef edgeuse, SUVertexRef* vertex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetEndVertex(SUEdgeUseRef edgeuse, SUVertexRef* vertex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetStartVertexNormal(SUEdgeUseRef edgeuse, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEdgeUseGetEndVertexNormal(SUEdgeUseRef edgeuse, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesClear(SUEntitiesRef entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesFill(SUEntitiesRef entities, SUGeometryInputRef geom_input, [NativeTypeName("bool")] byte weld_vertices);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetBoundingBox(SUEntitiesRef entities, [NativeTypeName("struct SUBoundingBox3D *")] SUBoundingBox3D* bbox);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetBoundingBoxLLA(SUEntitiesRef entities, [NativeTypeName("struct SUBoundingBox3D *")] SUBoundingBox3D* bbox);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumFaces(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetFaces(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUFaceRef[]")] SUFaceRef* faces, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumCurves(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetCurves(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUCurveRef[]")] SUCurveRef* curves, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumArcCurves(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetArcCurves(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUArcCurveRef[]")] SUArcCurveRef* arccurves, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumGuidePoints(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetGuidePoints(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUGuidePointRef[]")] SUGuidePointRef* guide_points, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumGuideLines(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetGuideLines(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUGuideLineRef[]")] SUGuideLineRef* guide_lines, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumEdges(SUEntitiesRef entities, [NativeTypeName("bool")] byte standalone_only, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetEdges(SUEntitiesRef entities, [NativeTypeName("bool")] byte standalone_only, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumPolyline3ds(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetPolyline3ds(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUPolyline3dRef[]")] SUPolyline3dRef* lines, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddFaces(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUFaceRef[]")] SUFaceRef* faces);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddEdges(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUEdgeRef[]")] SUEdgeRef* edges);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddCurves(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUCurveRef[]")] SUCurveRef* curves);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddArcCurves(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUArcCurveRef[]")] SUArcCurveRef* curves);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddGuidePoints(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUGuidePointRef[]")] SUGuidePointRef* guide_points);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddGuideLines(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUGuideLineRef[]")] SUGuideLineRef* guide_lines);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddGroup(SUEntitiesRef entities, SUGroupRef group);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddImage(SUEntitiesRef entities, SUImageRef image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddInstance(SUEntitiesRef entities, SUComponentInstanceRef instance, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddSectionPlanes(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUSectionPlaneRef[]")] SUSectionPlaneRef* section_planes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesAddTexts(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUTextRef[]")] SUTextRef* texts);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumGroups(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetGroups(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUGroupRef[]")] SUGroupRef* groups, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumImages(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetImages(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUImageRef[]")] SUImageRef* images, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumInstances(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetInstances(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentInstanceRef[]")] SUComponentInstanceRef* instances, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumSectionPlanes(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumTexts(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetSectionPlanes(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUSectionPlaneRef[]")] SUSectionPlaneRef* section_planes, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetNumDimensions(SUEntitiesRef entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetDimensions(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, SUDimensionRef* dimensions, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesGetTexts(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUTextRef[]")] SUTextRef* texts, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesTransform(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEntityRef[]")] SUEntityRef* elements, [NativeTypeName("const struct SUTransformation *")] SUTransformation* trans);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesTransformMultiple(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEntityRef[]")] SUEntityRef* elements, [NativeTypeName("const struct SUTransformation[]")] SUTransformation* tranforms);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesErase(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEntityRef[]")] SUEntityRef* elements);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesIsRecursivelyEmpty(SUEntitiesRef entities, bool* is_empty);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesHasSectionCuts(SUEntitiesRef entities, bool* has_section_cuts);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesEntityListFill(SUEntitiesRef entities, [NativeTypeName("enum SURefType")] SURefType type, SUEntityListRef list);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntitiesWeld(SUEntitiesRef entities, [NativeTypeName("size_t")] nuint num_edges, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, SUEntityListRef list);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SURefType")]
        public static extern SURefType SUEntityGetType(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetID(SUEntityRef entity, [NativeTypeName("int32_t *")] int* entity_id);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetPersistentID(SUEntityRef entity, [NativeTypeName("int64_t *")] long* entity_pid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetNumAttributeDictionaries(SUEntityRef entity, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetAttributeDictionaries(SUEntityRef entity, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUAttributeDictionaryRef[]")] SUAttributeDictionaryRef* dictionaries, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityAddAttributeDictionary(SUEntityRef entity, SUAttributeDictionaryRef dictionary);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetAttributeDictionary(SUEntityRef entity, [NativeTypeName("const char *")] sbyte* name, SUAttributeDictionaryRef* dictionary);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetModel(SUEntityRef entity, SUModelRef* model);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityGetParentEntities(SUEntityRef entity, SUEntitiesRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListCreate(SUEntityListRef* list);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListRelease(SUEntityListRef* list);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListBegin(SUEntityListRef list, SUEntityListIteratorRef* iterator);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListSize(SUEntityListRef list, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListIteratorCreate(SUEntityListIteratorRef* iterator);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListIteratorRelease(SUEntityListIteratorRef* iterator);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListIteratorGetEntity(SUEntityListIteratorRef iterator, SUEntityRef* entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListIteratorNext(SUEntityListIteratorRef iterator);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUEntityListIteratorIsInRange(SUEntityListIteratorRef iterator, bool* in_range);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUFaceToEntity(SUFaceRef face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUFaceRef SUFaceFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUFaceToDrawingElement(SUFaceRef face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUFaceRef SUFaceFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceCreate(SUFaceRef* face, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* vertices3d, SULoopInputRef* outer_loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceCreateSimple(SUFaceRef* face, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* vertices3d, [NativeTypeName("size_t")] nuint len);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNormal(SUFaceRef face, [NativeTypeName("struct SUVector3D *")] SUVector3D* normal);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceRelease(SUFaceRef* face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumEdges(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetEdges(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumEdgeUses(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetEdgeUses(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeUseRef[]")] SUEdgeUseRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetPlane(SUFaceRef face, [NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumVertices(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetVertices(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUVertexRef[]")] SUVertexRef* vertices, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetOuterLoop(SUFaceRef face, SULoopRef* loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumInnerLoops(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetInnerLoops(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULoopRef[]")] SULoopRef* loops, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceAddInnerLoop(SUFaceRef face, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* vertices3d, SULoopInputRef* loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumOpenings(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetOpenings(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUOpeningRef[]")] SUOpeningRef* openings, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetFrontMaterial(SUFaceRef face, SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceSetFrontMaterial(SUFaceRef face, SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetBackMaterial(SUFaceRef face, SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceSetBackMaterial(SUFaceRef face, SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceIsFrontMaterialAffine(SUFaceRef face, bool* is_affine);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceIsBackMaterialAffine(SUFaceRef face, bool* is_affine);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetArea(SUFaceRef face, double* area);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetAreaWithTransform(SUFaceRef face, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform, double* area);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceIsComplex(SUFaceRef face, bool* is_complex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetUVHelper(SUFaceRef face, [NativeTypeName("bool")] byte front, [NativeTypeName("bool")] byte back, SUTextureWriterRef texture_writer, SUUVHelperRef* uv_helper);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetUVHelperWithTextureHandle(SUFaceRef face, [NativeTypeName("bool")] byte front, [NativeTypeName("bool")] byte back, SUTextureWriterRef texture_writer, [NativeTypeName("long")] int textureHandle, SUUVHelperRef* uv_helper);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetNumAttachedDrawingElements(SUFaceRef face, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceGetAttachedDrawingElements(SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUDrawingElementRef[]")] SUDrawingElementRef* elems, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFaceReverse(SUFaceRef face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetFaceName(SUFontRef font, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetPointSize(SUFontRef font, [NativeTypeName("size_t *")] nuint* size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetBold(SUFontRef font, bool* is_bold);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetItalic(SUFontRef font, bool* is_italic);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetUseWorldSize(SUFontRef font, bool* use_world_size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUFontGetWorldSize(SUFontRef font, double* world_size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUFontToEntity(SUFontRef font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUFontRef SUFontFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputCreate(SUGeometryInputRef* geom_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputRelease(SUGeometryInputRef* geom_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputAddVertex(SUGeometryInputRef geom_input, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputSetVertices(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint num_vertices, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* points);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputAddEdge(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint vertex0_index, [NativeTypeName("size_t")] nuint vertex1_index, [NativeTypeName("size_t *")] nuint* added_edge_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputEdgeSetHidden(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputEdgeSetSoft(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte soft);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputEdgeSetSmooth(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte smooth);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputEdgeSetMaterial(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint edge_index, SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputEdgeSetLayer(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint edge_index, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputAddCurve(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint num_edges, [NativeTypeName("const size_t[]")] nuint* edge_indices, [NativeTypeName("size_t *")] nuint* added_curve_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputAddArcCurve(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint start_point, [NativeTypeName("size_t")] nuint end_point, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* center, [NativeTypeName("const struct SUVector3D *")] SUVector3D* normal, [NativeTypeName("size_t")] nuint num_segments, [NativeTypeName("size_t *")] nuint* added_curve_index, [NativeTypeName("size_t *")] nuint* control_edge_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputCreate(SULoopInputRef* loop_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputRelease(SULoopInputRef* loop_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputAddVertexIndex(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint vertex_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputEdgeSetHidden(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputEdgeSetSoft(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte soft);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputEdgeSetSmooth(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint edge_index, [NativeTypeName("bool")] byte smooth);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputEdgeSetMaterial(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint edge_index, SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputEdgeSetLayer(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint edge_index, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputAddCurve(SULoopInputRef loop_input, [NativeTypeName("size_t")] nuint first_edge_index, [NativeTypeName("size_t")] nuint last_edge_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopInputIsClosed(SULoopInputRef loop_input, bool* is_closed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputAddFace(SUGeometryInputRef geom_input, SULoopInputRef* outer_loop, [NativeTypeName("size_t *")] nuint* added_face_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceSetReverse(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, [NativeTypeName("bool")] byte reverse);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceSetLayer(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceAddInnerLoop(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, SULoopInputRef* loop_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceSetFrontMaterial(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, [NativeTypeName("const struct SUMaterialInput *")] SUMaterialInput* material_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceSetBackMaterial(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, [NativeTypeName("const struct SUMaterialInput *")] SUMaterialInput* material_input);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputFaceSetHidden(SUGeometryInputRef geom_input, [NativeTypeName("size_t")] nuint face_index, [NativeTypeName("bool")] byte hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGeometryInputGetCounts(SUGeometryInputRef geom_input, [NativeTypeName("size_t *")] nuint* vertices_count, [NativeTypeName("size_t *")] nuint* faces_count, [NativeTypeName("size_t *")] nuint* edge_count, [NativeTypeName("size_t *")] nuint* curve_count, [NativeTypeName("size_t *")] nuint* arc_count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUGroupToEntity(SUGroupRef group);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGroupRef SUGroupFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUGroupToDrawingElement(SUGroupRef group);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGroupRef SUGroupFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUComponentInstanceRef SUGroupToComponentInstance(SUGroupRef group);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGroupRef SUGroupFromComponentInstance(SUComponentInstanceRef component_inst);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupCreate(SUGroupRef* group);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupSetName(SUGroupRef group, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupGetName(SUGroupRef group, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupGetGuid(SUGroupRef group, SUStringRef* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupSetGuid(SUGroupRef group, [NativeTypeName("const char *")] sbyte* guid_str);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupSetTransform(SUGroupRef group, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupGetTransform(SUGroupRef group, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupGetEntities(SUGroupRef group, SUEntitiesRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGroupGetDefinition(SUGroupRef group, SUComponentDefinitionRef* component);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUGuideLineToEntity(SUGuideLineRef guide_line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGuideLineRef SUGuideLineFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUGuideLineToDrawingElement(SUGuideLineRef guide_line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGuideLineRef SUGuideLineFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuideLineCreateFinite(SUGuideLineRef* guide_line, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* start, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* end);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuideLineCreateInfinite(SUGuideLineRef* guide_line, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("const struct SUVector3D *")] SUVector3D* direction);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuideLineRelease(SUGuideLineRef* guide_line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuideLineGetData(SUGuideLineRef guide_line, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* start, [NativeTypeName("struct SUVector3D *")] SUVector3D* direction, bool* isinfinite);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUGuidePointToEntity(SUGuidePointRef guide_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGuidePointRef SUGuidePointFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUGuidePointToDrawingElement(SUGuidePointRef guide_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUGuidePointRef SUGuidePointFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuidePointCreate(SUGuidePointRef* guide_point, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuidePointRelease(SUGuidePointRef* guide_point);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuidePointGetPosition(SUGuidePointRef guide_point, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuidePointGetFromPosition(SUGuidePointRef guide_point, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGuidePointGetDisplayAsLine(SUGuidePointRef guide_point, bool* as_line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUImageToEntity(SUImageRef image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUImageRef SUImageFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUImageToDrawingElement(SUImageRef image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUImageRef SUImageFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageCreateFromFile(SUImageRef* image, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageCreateFromImageRep(SUImageRef* image, SUImageRepRef image_rep);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetImageRep(SUImageRef image, SUImageRepRef* image_rep);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetName(SUImageRef image, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageSetName(SUImageRef image, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetTransform(SUImageRef image, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageSetTransform(SUImageRef image, [NativeTypeName("const struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetFileName(SUImageRef image, SUStringRef* file_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetDimensions(SUImageRef image, double* width, double* height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetPixelDimensions(SUImageRef image, [NativeTypeName("size_t *")] nuint* width, [NativeTypeName("size_t *")] nuint* height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetDataSize(SUImageRef image, [NativeTypeName("size_t *")] nuint* data_size, [NativeTypeName("size_t *")] nuint* bits_per_pixel);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageGetData(SUImageRef image, [NativeTypeName("size_t")] nuint data_size, [NativeTypeName("SUByte[]")] byte* pixel_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct SUColorOrder")]
        public static extern SUColorOrder SUGetColorOrder();

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepCreate(SUImageRepRef* image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepRelease(SUImageRepRef* image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepCopy(SUImageRepRef image, SUImageRepRef copy_image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepSetData(SUImageRepRef image, [NativeTypeName("size_t")] nuint width, [NativeTypeName("size_t")] nuint height, [NativeTypeName("size_t")] nuint bits_per_pixel, [NativeTypeName("size_t")] nuint row_padding, [NativeTypeName("const SUByte[]")] byte* pixel_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepLoadFile(SUImageRepRef image, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepSaveToFile(SUImageRepRef image, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetPixelDimensions(SUImageRepRef image, [NativeTypeName("size_t *")] nuint* width, [NativeTypeName("size_t *")] nuint* height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetRowPadding(SUImageRepRef image, [NativeTypeName("size_t *")] nuint* row_padding);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepResize(SUImageRepRef image, [NativeTypeName("size_t")] nuint width, [NativeTypeName("size_t")] nuint height);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepConvertTo32BitsPerPixel(SUImageRepRef image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetDataSize(SUImageRepRef image, [NativeTypeName("size_t *")] nuint* data_size, [NativeTypeName("size_t *")] nuint* bits_per_pixel);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetData(SUImageRepRef image, [NativeTypeName("size_t")] nuint data_size, [NativeTypeName("SUByte[]")] byte* pixel_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetDataAsColors(SUImageRepRef image, [NativeTypeName("SUColor[]")] SUColor* color_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUImageRepGetColorAtUV(SUImageRepRef image, double u, double v, [NativeTypeName("bool")] byte bilinear, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathCreate(SUInstancePathRef* instance_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathCreateCopy(SUInstancePathRef* instance_path, SUInstancePathRef source_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathRelease(SUInstancePathRef* instance_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathPushInstance(SUInstancePathRef instance_path, SUComponentInstanceRef component_instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathPopInstance(SUInstancePathRef instance_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathSetLeaf(SUInstancePathRef instance_path, SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetPathDepth(SUInstancePathRef instance_path, [NativeTypeName("size_t *")] nuint* depth);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetFullDepth(SUInstancePathRef instance_path, [NativeTypeName("size_t *")] nuint* full_depth);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetTransform(SUInstancePathRef instance_path, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetTransformAtDepth(SUInstancePathRef instance_path, [NativeTypeName("size_t")] nuint depth, [NativeTypeName("struct SUTransformation *")] SUTransformation* transform);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetInstanceAtDepth(SUInstancePathRef instance_path, [NativeTypeName("size_t")] nuint depth, SUComponentInstanceRef* instance);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetLeafAsEntity(SUInstancePathRef instance_path, SUEntityRef* entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetLeaf(SUInstancePathRef instance_path, SUDrawingElementRef* drawing_element);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathIsValid(SUInstancePathRef instance_path, bool* valid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathIsEmpty(SUInstancePathRef instance_path, bool* empty);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathContains(SUInstancePathRef instance_path, SUEntityRef entity, bool* contains);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetPersistentID(SUInstancePathRef instance_path, SUStringRef* pid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUInstancePathGetPersistentIDAtDepth(SUInstancePathRef instance_path, [NativeTypeName("size_t")] nuint depth, SUStringRef* pid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SULayerToEntity(SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SULayerRef SULayerFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerCreate(SULayerRef* layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerRelease(SULayerRef* layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetName(SULayerRef layer, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetDisplayName(SULayerRef layer, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerSetName(SULayerRef layer, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetMaterial(SULayerRef layer, SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetVisibility(SULayerRef layer, bool* visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerSetVisibility(SULayerRef layer, [NativeTypeName("bool")] byte visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetLineStyle(SULayerRef layer, SULineStyleRef* line_style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerSetLineStyle(SULayerRef layer, SULineStyleRef line_style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerClearLineStyle(SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetSceneBehavior(SULayerRef layer, [NativeTypeName("enum SULayerVisibilityDefaultType *")] SULayerVisibilityDefaultType* default_type, [NativeTypeName("enum SULayerVisibilityNewSceneType *")] SULayerVisibilityNewSceneType* new_scene_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerSetSceneBehavior(SULayerRef layer, [NativeTypeName("enum SULayerVisibilityDefaultType")] SULayerVisibilityDefaultType default_type, [NativeTypeName("enum SULayerVisibilityNewSceneType")] SULayerVisibilityNewSceneType new_scene_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGetParentLayerFolder(SULayerRef layer, SULayerFolderRef* layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SULayerFolderToEntity(SULayerFolderRef layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SULayerFolderRef SULayerFolderFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderCreate(SULayerFolderRef* layer_folder, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderRelease(SULayerFolderRef* layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetName(SULayerFolderRef layer_folder, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderSetName(SULayerFolderRef layer_folder, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetVisibility(SULayerFolderRef layer_folder, bool* visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderSetVisibility(SULayerFolderRef layer_folder, [NativeTypeName("bool")] byte visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGroupGetVisibleOnNewScenes(SULayerFolderRef layer_folder, bool* visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerGroupSetVisibleOnNewScenes(SULayerFolderRef layer_folder, [NativeTypeName("bool")] byte visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderAddLayer(SULayerFolderRef layer_folder, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderRemoveLayer(SULayerFolderRef layer_folder, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetNumLayers(SULayerFolderRef layer_folder, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetLayers(SULayerFolderRef layer_folder, [NativeTypeName("size_t")] nuint len, SULayerRef* layers, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderAddLayerFolder(SULayerFolderRef layer_folder, SULayerFolderRef add_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetNumLayerFolders(SULayerFolderRef layer_folder, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetLayerFolders(SULayerFolderRef layer_folder, [NativeTypeName("size_t")] nuint len, SULayerFolderRef* layer_folders, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULayerFolderGetParentLayerFolder(SULayerFolderRef layer_folder, SULayerFolderRef* parent);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SULineStyleToEntity(SULineStyleRef line_style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SULineStyleRef SULineStyleFromEntity(SUEntityRef entity_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULineStyleGetName(SULineStyleRef line_style, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULineStylesGetNumLineStyles(SULineStylesRef line_styles, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULineStylesGetLineStyleNames(SULineStylesRef line_styles, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* line_styles_provider_names, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULineStylesGetLineStyleByName(SULineStylesRef line_styles, [NativeTypeName("const char *")] sbyte* name, SULineStyleRef* line_style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULocationGetLatLong(SULocationRef location, double* latitude, double* longitude);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULocationSetLatLong(SULocationRef location, double latitude, double longitude);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULocationSetNorthAngle(SULocationRef location, double north_angle);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SULoopToEntity(SULoopRef loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SULoopRef SULoopFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetNumVertices(SULoopRef loop, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetVertices(SULoopRef loop, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUVertexRef[]")] SUVertexRef* vertices, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetEdges(SULoopRef loop, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetWinding(SULoopRef loop, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector3d, [NativeTypeName("enum SULoopWinding *")] SULoopWinding* orientation);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopIsEdgeReversed(SULoopRef loop, SUEdgeRef edge, bool* reversed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetFace(SULoopRef loop, SUFaceRef* face);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopIsConvex(SULoopRef loop, bool* convex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopIsOuterLoop(SULoopRef loop, bool* outer_loop);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULoopGetEdgeUses(SULoopRef loop, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeUseRef[]")] SUEdgeUseRef* edge_uses, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUMaterialToEntity(SUMaterialRef material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUMaterialRef SUMaterialFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialCreate(SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialRelease(SUMaterialRef* material);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetName(SUMaterialRef material, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetName(SUMaterialRef material, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetNameLegacyBehavior(SUMaterialRef material, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetColor(SUMaterialRef material, [NativeTypeName("const SUColor *")] SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetColor(SUMaterialRef material, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetTexture(SUMaterialRef material, SUTextureRef texture);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetTexture(SUMaterialRef material, SUTextureRef* texture);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetOpacity(SUMaterialRef material, double* alpha);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetOpacity(SUMaterialRef material, double alpha);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetUseOpacity(SUMaterialRef material, bool* use_opacity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetUseOpacity(SUMaterialRef material, [NativeTypeName("bool")] byte use_opacity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetType(SUMaterialRef material, [NativeTypeName("enum SUMaterialType")] SUMaterialType type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetType(SUMaterialRef material, [NativeTypeName("enum SUMaterialType *")] SUMaterialType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialIsDrawnTransparent(SUMaterialRef material, bool* transparency);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetOwnerType(SUMaterialRef material, [NativeTypeName("enum SUMaterialOwnerType *")] SUMaterialOwnerType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialSetColorizeType(SUMaterialRef material, [NativeTypeName("enum SUMaterialColorizeType")] SUMaterialColorizeType type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetColorizeType(SUMaterialRef material, [NativeTypeName("enum SUMaterialColorizeType *")] SUMaterialColorizeType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMaterialGetColorizeDeltas(SUMaterialRef material, double* hue, double* saturation, double* lightness);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperCreate(SUMeshHelperRef* mesh_ref, SUFaceRef face_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperCreateWithTextureWriter(SUMeshHelperRef* mesh_ref, SUFaceRef face_ref, SUTextureWriterRef texture_writer_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperCreateWithUVHelper(SUMeshHelperRef* mesh_ref, SUFaceRef face_ref, SUUVHelperRef uv_helper_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperRelease(SUMeshHelperRef* mesh_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetNumTriangles(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetNumVertices(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetVertexIndices(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t")] nuint len, [NativeTypeName("size_t[]")] nuint* indices, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetVertices(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* vertices, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetFrontSTQCoords(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* stq, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetBackSTQCoords(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* stq, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUMeshHelperGetNormals(SUMeshHelperRef mesh_ref, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUVector3D[]")] SUVector3D* normals, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelCreate(SUModelRef* model);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelCreateFromFile(SUModelRef* model, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelCreateFromFileWithStatus(SUModelRef* model, [NativeTypeName("const char *")] sbyte* file_path, [NativeTypeName("enum SUModelLoadStatus *")] SUModelLoadStatus* status);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelCreateFromBuffer(SUModelRef* model, [NativeTypeName("const unsigned char *")] byte* buffer, [NativeTypeName("size_t")] nuint buffer_size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelCreateFromBufferWithStatus(SUModelRef* model, [NativeTypeName("const unsigned char *")] byte* buffer, [NativeTypeName("size_t")] nuint buffer_size, [NativeTypeName("enum SUModelLoadStatus *")] SUModelLoadStatus* status);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRelease(SUModelRef* model);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUModelRef SUModelFromExisting([NativeTypeName("uintptr_t")] nuint data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetEntities(SUModelRef model, SUEntitiesRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetActiveEntities(SUModelRef model, SUEntitiesRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetActivePath(SUModelRef model, SUInstancePathRef* instance_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumMaterials(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetMaterials(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUMaterialRef[]")] SUMaterialRef* materials, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddMaterials(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUMaterialRef[]")] SUMaterialRef* materials);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumComponentDefinitions(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetComponentDefinitions(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentDefinitionRef[]")] SUComponentDefinitionRef* definitions, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumGroupDefinitions(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetGroupDefinitions(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentDefinitionRef[]")] SUComponentDefinitionRef* definitions, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumImageDefinitions(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetImageDefinitions(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentDefinitionRef[]")] SUComponentDefinitionRef* definitions, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddComponentDefinitions(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUComponentDefinitionRef[]")] SUComponentDefinitionRef* components);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRemoveComponentDefinitions(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUComponentDefinitionRef[]")] SUComponentDefinitionRef* components);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSaveToFile(SUModelRef model, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSaveToFileWithVersion(SUModelRef model, [NativeTypeName("const char *")] sbyte* file_path, [NativeTypeName("enum SUModelVersion")] SUModelVersion version);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetCamera(SUModelRef model, SUCameraRef* camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetCamera(SUModelRef model, SUCameraRef* camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumScenes(SUModelRef model, [NativeTypeName("size_t *")] nuint* num_scenes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumLayers(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLayers(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerRef[]")] SULayerRef* layers, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddLayers(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SULayerRef[]")] SULayerRef* layers);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetDefaultLayer(SUModelRef model, SULayerRef* layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRemoveLayers(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerRef[]")] SULayerRef* layers);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetActiveLayer(SUModelRef model, SULayerRef* layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetActiveLayer(SUModelRef model, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetVersion(SUModelRef model, int* major, int* minor, int* build);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumAttributeDictionaries(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetAttributeDictionaries(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUAttributeDictionaryRef[]")] SUAttributeDictionaryRef* dictionaries, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetAttributeDictionary(SUModelRef model, [NativeTypeName("const char *")] sbyte* name, SUAttributeDictionaryRef* dictionary);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelIsGeoReferenced(SUModelRef model, bool* is_geo_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLocation(SUModelRef model, SULocationRef* location);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetStatistics(SUModelRef model, [NativeTypeName("struct SUModelStatistics *")] SUModelStatistics* statistics);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetGeoReference(SUModelRef model, double latitude, double longitude, double altitude, [NativeTypeName("bool")] byte is_z_value_centered, [NativeTypeName("bool")] byte is_on_ocean_floor);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetRenderingOptions(SUModelRef model, SURenderingOptionsRef* rendering_options);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetShadowInfo(SUModelRef model, SUShadowInfoRef* shadow_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetOptionsManager(SUModelRef model, SUOptionsManagerRef* options_manager);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNorthCorrection(SUModelRef model, double* north_correction);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelMergeCoplanarFaces(SUModelRef model);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetScenes(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUSceneRef[]")] SUSceneRef* scenes, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetSceneWithName(SUModelRef model, [NativeTypeName("const char *")] sbyte* name, SUSceneRef* scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddScenes(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const SUSceneRef[]")] SUSceneRef* scenes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddScene(SUModelRef model, int index, SUSceneRef scene, int* out_index);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetActiveScene(SUModelRef model, SUSceneRef* scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetActiveScene(SUModelRef model, SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddMatchPhotoScene(SUModelRef model, [NativeTypeName("const char *")] sbyte* image_file, SUCameraRef camera, [NativeTypeName("const char *")] sbyte* scene_name, SUSceneRef* scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetName(SUModelRef model, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetName(SUModelRef model, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetPath(SUModelRef model, SUStringRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetTitle(SUModelRef model, SUStringRef* title);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetDescription(SUModelRef model, SUStringRef* description);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelSetDescription(SUModelRef model, [NativeTypeName("const char *")] sbyte* description);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetUnits(SUModelRef model, [NativeTypeName("enum SUModelUnits *")] SUModelUnits* units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetClassifications(SUModelRef model, SUClassificationsRef* classifications);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetAxes(SUModelRef model, SUAxesRef* axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetStyles(SUModelRef model, SUStylesRef* styles);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetInstancePathByPid(SUModelRef model, SUStringRef pid_ref, SUInstancePathRef* instance_path_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumFonts(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetFonts(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUFontRef[]")] SUFontRef* fonts, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetDimensionStyle(SUModelRef model, SUDimensionStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLengthFormatter(SUModelRef model, SULengthFormatterRef* formatter);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGenerateUniqueMaterialName(SUModelRef model, [NativeTypeName("const char *")] sbyte* in_name, SUStringRef* out_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelFixErrors(SUModelRef model);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelOrientFacesConsistently(SUModelRef model, [NativeTypeName("bool")] byte recurse_components);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLineStyles(SUModelRef model, SULineStylesRef* line_styles);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelLoadDefinition(SUModelRef model, [NativeTypeName("const char *")] sbyte* filename, SUComponentDefinitionRef* definition);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelLoadDefinitionWithStatus(SUModelRef model, [NativeTypeName("const char *")] sbyte* filename, SUComponentDefinitionRef* definition, [NativeTypeName("enum SUModelLoadStatus *")] SUModelLoadStatus* status);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRemoveMaterials(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUMaterialRef[]")] SUMaterialRef* materials);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRemoveScenes(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUSceneRef[]")] SUSceneRef* scenes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumAllMaterials(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetAllMaterials(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUMaterialRef[]")] SUMaterialRef* materials, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetGuid(SUModelRef model, SUStringRef* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLayersByPersistentIDs(SUModelRef model, [NativeTypeName("size_t")] nuint num_pids, [NativeTypeName("const int64_t[]")] long* pids, [NativeTypeName("SULayerRef[]")] SULayerRef* layers);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelIsDrawingElementVisible(SUModelRef model, SUInstancePathRef path, bool* visible);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetEntitiesByPersistentIDs(SUModelRef model, [NativeTypeName("size_t")] nuint num_pids, [NativeTypeName("const int64_t[]")] long* pids, [NativeTypeName("SUEntityRef[]")] SUEntityRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetSelection(SUModelRef model, SUSelectionRef* selection);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumLayerFolders(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetLayerFolders(SUModelRef model, [NativeTypeName("size_t")] nuint len, SULayerFolderRef* layer_folders, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelPurgeEmptyLayerFolders(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelAddLayerFolder(SUModelRef model, SULayerFolderRef layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelPurgeUnusedLayers(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetNumTopLevelLayers(SUModelRef model, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetTopLevelLayers(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerRef[]")] SULayerRef* layers, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelRemoveLayerFolders(SUModelRef model, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerFolderRef[]")] SULayerFolderRef* layer_folders);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUModelGetEntitiesOfTypeByPersistentIDs(SUModelRef model, [NativeTypeName("const uint32_t")] uint type_flags, [NativeTypeName("const size_t")] nuint num_pids, [NativeTypeName("const int64_t[]")] long* pids, [NativeTypeName("SUEntityRef[]")] SUEntityRef* entities);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOpeningGetNumPoints(SUOpeningRef opening, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOpeningGetPoints(SUOpeningRef opening, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* points, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOpeningRelease(SUOpeningRef* opening);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsManagerGetNumOptionsProviders(SUOptionsManagerRef options_manager, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsManagerGetOptionsProviderNames(SUOptionsManagerRef options_manager, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* options_provider_names, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsManagerGetOptionsProviderByName(SUOptionsManagerRef options_manager, [NativeTypeName("const char *")] sbyte* name, SUOptionsProviderRef* options_provider);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsProviderGetNumKeys(SUOptionsProviderRef options_provider, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsProviderGetKeys(SUOptionsProviderRef options_provider, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* keys, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsProviderGetValue(SUOptionsProviderRef options_provider, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef* value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsProviderSetValue(SUOptionsProviderRef options_provider, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUOptionsProviderGetName(SUOptionsProviderRef options_provider, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUPolyline3dToEntity(SUPolyline3dRef line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUPolyline3dRef SUPolyline3dFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUPolyline3dToDrawingElement(SUPolyline3dRef line);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUPolyline3dRef SUPolyline3dFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPolyline3dCreate(SUPolyline3dRef* polyline);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPolyline3dRelease(SUPolyline3dRef* polyline);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPolyline3dAddPoints(SUPolyline3dRef polyline, [NativeTypeName("size_t")] nuint num_points, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* points);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPolyline3dGetNumPoints(SUPolyline3dRef line, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUPolyline3dGetPoints(SUPolyline3dRef line, [NativeTypeName("size_t")] nuint len, [NativeTypeName("struct SUPoint3D[]")] SUPoint3D* points, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURenderingOptionsGetNumKeys(SURenderingOptionsRef rendering_options, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURenderingOptionsGetKeys(SURenderingOptionsRef rendering_options, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* keys, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURenderingOptionsSetValue(SURenderingOptionsRef rendering_options, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef value_in);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SURenderingOptionsGetValue(SURenderingOptionsRef rendering_options, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef* value_out);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUSceneToEntity(SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUSceneRef SUSceneFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneCreate(SUSceneRef* scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneRelease(SUSceneRef* scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseCamera(SUSceneRef scene, bool* use_camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseCamera(SUSceneRef scene, [NativeTypeName("bool")] byte use_camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetCamera(SUSceneRef scene, SUCameraRef* camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetCamera(SUSceneRef scene, SUCameraRef camera);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetIncludeInAnimation(SUSceneRef scene, bool* include_in_animation);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetIncludeInAnimation(SUSceneRef scene, [NativeTypeName("bool")] byte include_in_animation);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetName(SUSceneRef scene, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetName(SUSceneRef scene, [NativeTypeName("const char *")] sbyte* scene_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetRenderingOptions(SUSceneRef scene, SURenderingOptionsRef* options);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetShadowInfo(SUSceneRef scene, SUShadowInfoRef* shadow_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseShadowInfo(SUSceneRef scene, bool* use_shadow_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseShadowInfo(SUSceneRef scene, [NativeTypeName("bool")] byte use_shadow_info);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseRenderingOptions(SUSceneRef scene, bool* use_rendering_options);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseRenderingOptions(SUSceneRef scene, [NativeTypeName("bool")] byte use_rendering_options);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseHidden(SUSceneRef scene, bool* use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseHidden(SUSceneRef scene, [NativeTypeName("bool")] byte use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseHiddenGeometry(SUSceneRef scene, bool* use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseHiddenGeometry(SUSceneRef scene, [NativeTypeName("bool")] byte use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseHiddenObjects(SUSceneRef scene, bool* use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseHiddenObjects(SUSceneRef scene, [NativeTypeName("bool")] byte use_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseHiddenLayers(SUSceneRef scene, bool* use_hidden_layers);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseHiddenLayers(SUSceneRef scene, [NativeTypeName("bool")] byte use_hidden_layers);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseSectionPlanes(SUSceneRef scene, bool* use_section_planes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseSectionPlanes(SUSceneRef scene, [NativeTypeName("bool")] byte use_section_planes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetNumLayers(SUSceneRef scene, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetLayers(SUSceneRef scene, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerRef[]")] SULayerRef* layers, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneAddLayer(SUSceneRef scene, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneRemoveLayer(SUSceneRef scene, SULayerRef layer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneClearLayers(SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetNumLayerFolders(SUSceneRef scene, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetLayerFolders(SUSceneRef scene, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULayerFolderRef[]")] SULayerFolderRef* layer_folders, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneAddLayerFolder(SUSceneRef scene, SULayerFolderRef layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneRemoveLayerFolder(SUSceneRef scene, SULayerFolderRef layer_folder);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneClearLayerFolders(SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetAxes(SUSceneRef scene, SUAxesRef* axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetUseAxes(SUSceneRef scene, [NativeTypeName("bool")] byte use_axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetUseAxes(SUSceneRef scene, bool* use_axes);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetNumHiddenEntities(SUSceneRef scene, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetHiddenEntities(SUSceneRef scene, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEntityRef[]")] SUEntityRef* entities, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetFlags(SUSceneRef scene, [NativeTypeName("uint32_t")] uint flags);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetFlags(SUSceneRef scene, [NativeTypeName("uint32_t *")] uint* flags);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetSketchAxesDisplayed(SUSceneRef scene, [NativeTypeName("bool")] byte displayed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetSketchAxesDisplayed(SUSceneRef scene, bool* displayed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetPhotoMatchImageDisplayed(SUSceneRef scene, bool* displayed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneClearPhotoMatchImage(SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetStyle(SUSceneRef scene, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneCopy(SUSceneRef scene, SUSceneRef copy_scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneActivate(SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneSetDrawingElementHidden(SUSceneRef scene, SUDrawingElementRef drawing_element, [NativeTypeName("bool")] byte is_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSceneGetDrawingElementHidden(SUSceneRef scene, SUDrawingElementRef drawing_element, bool* is_hidden);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSchemaGetSchemaType(SUSchemaRef schema_ref, [NativeTypeName("const char *")] sbyte* schema_type_name, SUSchemaTypeRef* schema_type_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUSectionPlaneToEntity(SUSectionPlaneRef sectionPlane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUSectionPlaneRef SUSectionPlaneFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUSectionPlaneToDrawingElement(SUSectionPlaneRef sectionPlane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUSectionPlaneRef SUSectionPlaneFromDrawingElement(SUDrawingElementRef drawing_elem);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneCreate(SUSectionPlaneRef* sectionPlane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneRelease(SUSectionPlaneRef* sectionPlane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneSetPlane(SUSectionPlaneRef sectionPlane, [NativeTypeName("const struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneGetPlane(SUSectionPlaneRef sectionPlane, [NativeTypeName("struct SUPlane3D *")] SUPlane3D* plane);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneIsActive(SUSectionPlaneRef sectionPlane, bool* is_active);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneGetName(SUSectionPlaneRef sectionPlane, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneSetName(SUSectionPlaneRef sectionPlane, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneGetSymbol(SUSectionPlaneRef sectionPlane, SUStringRef* symbol);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSectionPlaneSetSymbol(SUSectionPlaneRef sectionPlane, [NativeTypeName("const char *")] sbyte* symbol);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionAdd(SUSelectionRef selection, [NativeTypeName("size_t")] nuint num_elements, [NativeTypeName("const SUDrawingElementRef[]")] SUDrawingElementRef* elements);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionRemove(SUSelectionRef selection, [NativeTypeName("size_t")] nuint num_elements, [NativeTypeName("const SUDrawingElementRef[]")] SUDrawingElementRef* elements);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionToggle(SUSelectionRef selection, [NativeTypeName("size_t")] nuint num_elements, [NativeTypeName("const SUDrawingElementRef[]")] SUDrawingElementRef* elements);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionClear(SUSelectionRef selection);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionInvert(SUSelectionRef selection);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionGetNumElements(SUSelectionRef selection, [NativeTypeName("size_t *")] nuint* num_elements);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionGetEntityList(SUSelectionRef selection, SUEntityListRef* entity_list);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSelectionIsType(SUSelectionRef selection, [NativeTypeName("enum SUSelectionType")] SUSelectionType type, bool* is_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUShadowInfoGetNumKeys(SUShadowInfoRef shadow_info, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUShadowInfoGetKeys(SUShadowInfoRef shadow_info, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStringRef[]")] SUStringRef* keys, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUShadowInfoGetValue(SUShadowInfoRef shadow_info, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef* value_out);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUShadowInfoSetValue(SUShadowInfoRef shadow_info, [NativeTypeName("const char *")] sbyte* key, SUTypedValueRef value_in);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUSkpReadGuid([NativeTypeName("const char *")] sbyte* file_path, SUStringRef* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleCreate(SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleCreateFromFile(SUStyleRef* style, [NativeTypeName("const char *")] sbyte* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleRelease(SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUStyleToEntity(SUStyleRef style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUStyleRef SUStyleFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleSetName(SUStyleRef style, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetName(SUStyleRef style, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetDisplayName(SUStyleRef style, SUStringRef* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleSetDescription(SUStyleRef style, [NativeTypeName("const char *")] sbyte* description);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetDescription(SUStyleRef style, SUStringRef* description);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetPath(SUStyleRef style, SUStringRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetGuid(SUStyleRef style, SUStringRef* guid);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetDisplaysWatermark(SUStyleRef style, bool* shows_mark);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleSaveToFile(SUStyleRef style, [NativeTypeName("const char *")] sbyte* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleSetProperty(SUStyleRef style, [NativeTypeName("enum SUStylePropertyType")] SUStylePropertyType type, SUTypedValueRef value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetProperty(SUStyleRef style, [NativeTypeName("enum SUStylePropertyType")] SUStylePropertyType type, SUTypedValueRef* value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStyleGetThumbnail(SUStyleRef style, SUImageRepRef* image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesAddStyle(SUStylesRef styles, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("bool")] byte activate);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetNumStyles(SUStylesRef styles, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetStyles(SUStylesRef styles, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUStyleRef[]")] SUStyleRef* style_array, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetActiveStyle(SUStylesRef styles, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetSelectedStyle(SUStylesRef styles, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetStyleByGuid(SUStylesRef styles, [NativeTypeName("const char *")] sbyte* guid, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetStyleByPath(SUStylesRef styles, [NativeTypeName("const char *")] sbyte* path, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesGetActiveStyleChanged(SUStylesRef styles, bool* changed);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesApplyStyleToScene(SUStylesRef styles, SUStyleRef style, SUSceneRef scene);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesSetSelectedStyle(SUStylesRef styles, SUStyleRef style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStylesRemoveStyle(SUStylesRef styles, SUStyleRef* style);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUTextToEntity(SUTextRef text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUTextRef SUTextFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUDrawingElementRef SUTextToDrawingElement(SUTextRef text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUTextRef SUTextFromDrawingElement(SUDrawingElementRef element);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextCreate(SUTextRef* text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextRelease(SUTextRef* text);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetString(SUTextRef text, [NativeTypeName("const char *")] sbyte* @string);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetString(SUTextRef text, SUStringRef* @string);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetFont(SUTextRef text, SUFontRef font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetFont(SUTextRef text, SUFontRef* font);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetLeaderType(SUTextRef text, [NativeTypeName("enum SUTextLeaderType")] SUTextLeaderType leader);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetLeaderType(SUTextRef text, [NativeTypeName("enum SUTextLeaderType *")] SUTextLeaderType* leader);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetArrowType(SUTextRef text, [NativeTypeName("enum SUArrowType")] SUArrowType arrow_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetArrowType(SUTextRef text, [NativeTypeName("enum SUArrowType *")] SUArrowType* arrow_type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetPoint(SUTextRef text, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetPoint(SUTextRef text, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* point, SUInstancePathRef* path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetLeaderVector(SUTextRef text, [NativeTypeName("const struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetLeaderVector(SUTextRef text, [NativeTypeName("struct SUVector3D *")] SUVector3D* vector);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetColor(SUTextRef text, [NativeTypeName("const SUColor *")] SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetColor(SUTextRef text, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextSetScreenPosition(SUTextRef text, [NativeTypeName("const double")] double percent_x, [NativeTypeName("const double")] double percent_y);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextGetScreenPosition(SUTextRef text, double* percent_x, double* percent_y);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUTextureToEntity(SUTextureRef texture);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUTextureRef SUTextureFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureCreateFromImageData(SUTextureRef* texture, [NativeTypeName("size_t")] nuint width, [NativeTypeName("size_t")] nuint height, [NativeTypeName("size_t")] nuint bits_per_pixel, [NativeTypeName("const SUByte[]")] byte* pixel_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureCreateFromImageRep(SUTextureRef* texture, SUImageRepRef image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureCreateFromFile(SUTextureRef* texture, [NativeTypeName("const char *")] sbyte* file_path, double s_scale, double t_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureRelease(SUTextureRef* texture);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetDimensions(SUTextureRef texture, [NativeTypeName("size_t *")] nuint* width, [NativeTypeName("size_t *")] nuint* height, double* s_scale, double* t_scale);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetImageDataSize(SUTextureRef texture, [NativeTypeName("size_t *")] nuint* data_size, [NativeTypeName("size_t *")] nuint* bits_per_pixel);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetImageData(SUTextureRef texture, [NativeTypeName("size_t")] nuint data_size, [NativeTypeName("SUByte[]")] byte* pixel_data);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetImageRep(SUTextureRef texture, SUImageRepRef* image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriteToFile(SUTextureRef texture, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureSetFileName(SUTextureRef texture, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetFileName(SUTextureRef texture, SUStringRef* file_name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetUseAlphaChannel(SUTextureRef texture, bool* alpha_channel_used);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetAverageColor(SUTextureRef texture, SUColor* color_val);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureGetColorizedImageRep(SUTextureRef texture, SUImageRepRef* image_rep);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriteOriginalToFile(SUTextureRef texture, [NativeTypeName("const char *")] sbyte* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterCreate(SUTextureWriterRef* writer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterRelease(SUTextureWriterRef* writer);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterLoadEntity(SUTextureWriterRef writer, SUEntityRef entity, [NativeTypeName("long *")] int* texture_id);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterLoadFace(SUTextureWriterRef writer, SUFaceRef face, [NativeTypeName("long *")] int* front_texture_id, [NativeTypeName("long *")] int* back_texture_id);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetNumTextures(SUTextureWriterRef writer, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterWriteTexture(SUTextureWriterRef writer, [NativeTypeName("long")] int texture_id, [NativeTypeName("const char *")] sbyte* path, [NativeTypeName("bool")] byte reduce_size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetImageRep(SUTextureWriterRef writer, [NativeTypeName("long")] int texture_id, SUImageRepRef* image);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterWriteAllTextures(SUTextureWriterRef writer, [NativeTypeName("const char *")] sbyte* directory);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterIsTextureAffine(SUTextureWriterRef writer, [NativeTypeName("long")] int texture_id, bool* is_affine);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetTextureFilePath(SUTextureWriterRef writer, [NativeTypeName("long")] int texture_id, SUStringRef* file_path);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetFrontFaceUVCoords(SUTextureWriterRef writer, SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* points, [NativeTypeName("struct SUPoint2D[]")] SUPoint2D* uv_coords);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetBackFaceUVCoords(SUTextureWriterRef writer, SUFaceRef face, [NativeTypeName("size_t")] nuint len, [NativeTypeName("const struct SUPoint3D[]")] SUPoint3D* points, [NativeTypeName("struct SUPoint2D[]")] SUPoint2D* uv_coords);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetTextureIdForEntity(SUTextureWriterRef writer, SUEntityRef entity, [NativeTypeName("long *")] int* texture_id);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTextureWriterGetTextureIdForFace(SUTextureWriterRef writer, SUFaceRef face, [NativeTypeName("bool")] byte front, [NativeTypeName("long *")] int* texture_id);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueCreate(SUTypedValueRef* typed_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueRelease(SUTypedValueRef* typed_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetType(SUTypedValueRef typed_value, [NativeTypeName("enum SUTypedValueType *")] SUTypedValueType* type);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetByte(SUTypedValueRef typed_value, [NativeTypeName("char *")] sbyte* byte_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetByte(SUTypedValueRef typed_value, [NativeTypeName("char")] sbyte byte_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetInt16(SUTypedValueRef typed_value, [NativeTypeName("int16_t *")] short* int16_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetInt16(SUTypedValueRef typed_value, [NativeTypeName("int16_t")] short int16_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetInt32(SUTypedValueRef typed_value, [NativeTypeName("int32_t *")] int* int32_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetInt32(SUTypedValueRef typed_value, [NativeTypeName("int32_t")] int int32_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetFloat(SUTypedValueRef typed_value, float* float_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetFloat(SUTypedValueRef typed_value, float float_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetDouble(SUTypedValueRef typed_value, double* double_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetDouble(SUTypedValueRef typed_value, double double_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetBool(SUTypedValueRef typed_value, bool* bool_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetBool(SUTypedValueRef typed_value, [NativeTypeName("bool")] byte bool_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetColor(SUTypedValueRef typed_value, SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetColor(SUTypedValueRef typed_value, [NativeTypeName("const SUColor *")] SUColor* color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetTime(SUTypedValueRef typed_value, [NativeTypeName("int64_t *")] long* time_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetTime(SUTypedValueRef typed_value, [NativeTypeName("int64_t")] long time_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetString(SUTypedValueRef typed_value, SUStringRef* string_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetString(SUTypedValueRef typed_value, [NativeTypeName("const char *")] sbyte* string_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetVector3d(SUTypedValueRef typed_value, [NativeTypeName("double[3]")] double* vector3d_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetVector3d(SUTypedValueRef typed_value, [NativeTypeName("const double[3]")] double* vector3d_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetUnitVector3d(SUTypedValueRef typed_value, [NativeTypeName("const double[3]")] double* vector3d_value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetArrayItems(SUTypedValueRef typed_value, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUTypedValueRef[]")] SUTypedValueRef* values, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueSetArrayItems(SUTypedValueRef typed_value, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUTypedValueRef[]")] SUTypedValueRef* values);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUTypedValueGetNumArrayItems(SUTypedValueRef typed_value, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUUVHelperRelease(SUUVHelperRef* uvhelper);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUUVHelperGetFrontUVQ(SUUVHelperRef uvhelper, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("struct SUUVQ *")] SUUVQ* uvq);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUUVHelperGetBackUVQ(SUUVHelperRef uvhelper, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* point, [NativeTypeName("struct SUUVQ *")] SUUVQ* uvq);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUEntityRef SUVertexToEntity(SUVertexRef vertex);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SUVertexRef SUVertexFromEntity(SUEntityRef entity);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetPosition(SUVertexRef vertex, [NativeTypeName("struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexSetPosition(SUVertexRef vertex, [NativeTypeName("const struct SUPoint3D *")] SUPoint3D* position);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetNumEdges(SUVertexRef vertex, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetEdges(SUVertexRef vertex, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUEdgeRef[]")] SUEdgeRef* edges, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetNumFaces(SUVertexRef vertex, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetFaces(SUVertexRef vertex, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SUFaceRef[]")] SUFaceRef* faces, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetNumLoops(SUVertexRef vertex, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUVertexGetLoops(SUVertexRef vertex, [NativeTypeName("size_t")] nuint len, [NativeTypeName("SULoopRef[]")] SULoopRef* loops, [NativeTypeName("size_t *")] nuint* count);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SUDegreesToRadians(double value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SURadiansToDegrees(double value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SUEquals(double val1, double val2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SULessThan(double val1, double val2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SULessThanOrEqual(double val1, double val2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SUGreaterThan(double val1, double val2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("bool")]
        public static extern byte SUGreaterThanOrEqual(double val1, double val2);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUColorBlend([NativeTypeName("const SUColor")] SUColor color1, [NativeTypeName("const SUColor")] SUColor color2, [NativeTypeName("const double")] double weight, SUColor* blended_color);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUColorGetNumNames([NativeTypeName("size_t *")] nuint* size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUColorGetNames([NativeTypeName("SUStringRef[]")] SUStringRef* names, [NativeTypeName("const size_t")] nuint size);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUColorSetByName(SUColor* color, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUColorSetByValue(SUColor* color, [NativeTypeName("const size_t")] nuint value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUGetExtensionLicense([NativeTypeName("const char *")] sbyte* extension_id, [NativeTypeName("struct SUExtensionLicense *")] SUExtensionLicense* out_license);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SUInitialize();

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SUTerminate();

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SUGetAPIVersion([NativeTypeName("size_t *")] nuint* major, [NativeTypeName("size_t *")] nuint* minor);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterCreate(SULengthFormatterRef* formatter);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterRelease(SULengthFormatterRef* formatter);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetPrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t *")] nuint* precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetPrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t")] nuint precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetAreaPrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t *")] nuint* precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetAreaPrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t")] nuint precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetVolumePrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t *")] nuint* precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetVolumePrecision(SULengthFormatterRef formatter, [NativeTypeName("size_t")] nuint precision);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetFormat(SULengthFormatterRef formatter, [NativeTypeName("enum SULengthFormatType *")] SULengthFormatType* format);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetFormat(SULengthFormatterRef formatter, [NativeTypeName("enum SULengthFormatType")] SULengthFormatType format);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SULengthUnitType *")] SULengthUnitType* units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetAreaUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SUAreaUnitType *")] SUAreaUnitType* units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetVolumeUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SUVolumeUnitType *")] SUVolumeUnitType* units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SULengthUnitType")] SULengthUnitType units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetAreaUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SUAreaUnitType")] SUAreaUnitType units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetVolumeUnits(SULengthFormatterRef formatter, [NativeTypeName("enum SUVolumeUnitType")] SUVolumeUnitType units);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetSuppressUnits(SULengthFormatterRef formatter, bool* suppress);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetSuppressUnits(SULengthFormatterRef formatter, [NativeTypeName("bool")] byte suppress);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetLengthString(SULengthFormatterRef formatter, double length, [NativeTypeName("bool")] byte strip, SUStringRef* @string);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetAreaString(SULengthFormatterRef formatter, double area, SUStringRef* @string);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetVolumeString(SULengthFormatterRef formatter, double volume, SUStringRef* @string);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterParseString(SULengthFormatterRef formatter, SUStringRef @string, double* value);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterSetForceInchDisplay(SULengthFormatterRef formatter, [NativeTypeName("bool")] byte force_inch);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SULengthFormatterGetForceInchDisplay(SULengthFormatterRef formatter, bool* force_inch);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringCreate(SUStringRef* out_string_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringCreateFromUTF8(SUStringRef* out_string_ref, [NativeTypeName("const char *")] sbyte* char_array);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringCreateFromUTF16(SUStringRef* out_string_ref, [NativeTypeName("const unichar *")] ushort* char_array);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringRelease(SUStringRef* string_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringGetUTF8Length(SUStringRef string_ref, [NativeTypeName("size_t *")] nuint* out_length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringGetUTF16Length(SUStringRef string_ref, [NativeTypeName("size_t *")] nuint* out_length);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringSetUTF8(SUStringRef string_ref, [NativeTypeName("const char *")] sbyte* char_array);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringSetUTF16(SUStringRef string_ref, [NativeTypeName("const unichar *")] ushort* char_array);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringGetUTF8(SUStringRef string_ref, [NativeTypeName("size_t")] nuint char_array_length, [NativeTypeName("char *")] sbyte* out_char_array, [NativeTypeName("size_t *")] nuint* out_number_of_chars_copied);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringGetUTF16(SUStringRef string_ref, [NativeTypeName("size_t")] nuint char_array_length, [NativeTypeName("unichar *")] ushort* out_char_array, [NativeTypeName("size_t *")] nuint* out_number_of_chars_copied);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringTrimLeft(SUStringRef string_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringTrimRight(SUStringRef string_ref);

        [DllImport("SketchUpAPI", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum SUResult")]
        public static extern SUResult SUStringCompare(SUStringRef a, SUStringRef b, int* result);
    }
}
