Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class TeethStatus
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property status_id As Integer

    Public Property pat_id As Integer

    Public Property tooth_nr As Integer

    Public Enum ToothType
        Permanent
        Deciduous
        Implant
        Pontic
        Saddle
        Missing
        SpaceClosed
        ClosedLeft
        ClosedRight
    End Enum

    <Column(TypeName:="ENUM('permanent', 'deciduous', 'implant', 'pontic', 'saddle', 'missing', 'space closed', 'closed left', 'closed right')")>
    <Required>
    Public Property tooth_type As ToothType = ToothType.Permanent

    Public Property crown As Boolean = False

    Public Enum CrownType
        Temporary
        Metal
        Gold
        MetalCeramic
        Ceramic
        PlaningCrown
    End Enum

    <Column(TypeName:="ENUM('temporary', 'metal', 'gold', 'metal ceramic', 'ceramic', 'planing crown')")>
    <Required>
    Public Property crown_type As CrownType = CrownType.MetalCeramic

    Public Property crown_insufficient As Boolean = False

    Public Property rct As Boolean = False

    Public Enum RctType
        StartedRct
        RootFilling
        InsufficientRootFilling
    End Enum

    <Column(TypeName:="ENUM('started rct', 'root filling', 'insufficient root filling')")>
    <Required>
    Public Property rct_type As RctType = RctType.RootFilling

    Public Property root_resection As Boolean = False

    Public Property post As Boolean = False

    Public Enum PostType
        Screw
        Metal
        GlassFiber
    End Enum

    <Column(TypeName:="ENUM('screw', 'metal', 'glass fiber')")>
    <Required>
    Public Property post_type As PostType = PostType.Metal

    Public Property ortho As Boolean = False

    Public Enum OrthoType
        Bracket
        Band
        Retainer
    End Enum

    <Column(TypeName:="ENUM('bracket', 'band', 'retainer')")>
    <Required>
    Public Property ortho_type As OrthoType = OrthoType.Bracket

    Public Property vitality As Boolean = False

    Public Enum VitalityType
        Plus
        PlusPlus
        Question
        Minus
    End Enum

    <Column(TypeName:="ENUM('+', '++', '?', '-')")>
    <Required>
    Public Property vitality_type As VitalityType = VitalityType.Plus

    Public Property mobility As Boolean = False

    Public Enum MobilityType
        Zero
        I
        II
        III
    End Enum

    <Column(TypeName:="ENUM('0', 'I', 'II', 'III')")>
    <Required>
    Public Property mobility_type As MobilityType = MobilityType.I

    Public Enum FillingType
        Intact
        Caries
        ArrestedCaries
        Cement
        Composite
        Amalgam
        Gold
        Ceramic
        Other1
        Other2
    End Enum

    Public Property filling_m_type As FillingType = FillingType.Intact
    Public Property filling_m_foren As Boolean = False
    Public Property filling_m_insufficient As Boolean = False

    Public Property filling_d_type As FillingType = FillingType.Intact
    Public Property filling_d_foren As Boolean = False
    Public Property filling_d_insufficient As Boolean = False

    Public Property filling_b_type As FillingType = FillingType.Intact
    Public Property filling_b_foren As Boolean = False
    Public Property filling_b_insufficient As Boolean = False

    Public Property filling_l_type As FillingType = FillingType.Intact
    Public Property filling_l_foren As Boolean = False
    Public Property filling_l_insufficient As Boolean = False

    Public Property filling_o_type As FillingType = FillingType.Intact
    Public Property filling_o_foren As Boolean = False
    Public Property filling_o_insufficient As Boolean = False

    Public Property filling_c_type As FillingType = FillingType.Intact
    Public Property filling_c_foren As Boolean = False
    Public Property filling_c_insufficient As Boolean = False

    Public Enum PonticType
        Temporary
        Gold
        Metal
        MetalCeramic
        Ceramic
    End Enum

    <Column(TypeName:="ENUM('temporary', 'gold', 'metal', 'metal ceramic', 'ceramic')")>
    <Required>
    Public Property pontic_type As PonticType = PonticType.MetalCeramic

    Public Property pontic_insufficient As Boolean = False

    Public Enum MissingType
        NoIntry
        Extracted
        NotErupted
        NoBud
        None
    End Enum

    <Column(TypeName:="ENUM('no intry', 'extracted', 'not erupted', 'no bud')")>
    <Required>
    Public Property missing_type As MissingType = MissingType.None

    Public Property is_destroyed As Boolean = False
    Public Property is_gum_recession As Boolean = False
    Public Property is_abrasion As Boolean = False
    Public Property is_fracture As Boolean = False
    Public Property is_impacted As Boolean = False
    Public Property is_erupting As Boolean = False
    Public Property is_neck_defect As Boolean = False
    Public Property is_sealed As Boolean = False
    Public Property is_veneer As Boolean = False
    Public Property is_foreign As Boolean = False
    Public Property is_apical_lesion As Boolean = False
    Public Property is_root_rest As Boolean = False
    Public Property is_question As Boolean = False
End Class