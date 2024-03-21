using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static managingadentalclinic.DataBase.TeethStatus;

namespace managingadentalclinic.DataBase
{
    public class TeethStatus
    {
        public enum RctType
        {
            StartedRct,
            RootFilling,
            InsufficientRootFilling
        }

        public enum PostType
        {
            Screw,
            Metal,
            GlassFiber
        }

        public enum OrthoType
        {
            Bracket,
            Band,
            Retainer
        }

        public enum VitalityType
        {
            Plus,
            PlusPlus,
            Question,
            Minus
        }

        public enum MobilityType
        {
            Zero,
            I,
            II,
            III
        }

        public enum FillingType
        {
            Intact,
            Caries,
            ArrestedCaries,
            Cement,
            Composite,
            Amalgam,
            Gold,
            Ceramic,
            Other1,
            Other2
        }

        public enum PonticType
        {
            Temporary,
            Gold,
            Metal,
            MetalCeramic,
            Ceramic
        }

        public enum MissingType
        {
            NoIntry,
            Extracted,
            NotErupted,
            NoBud,
            None
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int status_id { get; set; }

        public int pat_id { get; set; }

        public int tooth_nr { get; set; }
        public enum ToothType
        {
            Permanent,
            Deciduous,
            Implant,
            Pontic,
            Saddle,
            Missing,
            SpaceClosed,
            ClosedLeft,
            ClosedRight
        }

        [Column(TypeName = "ENUM('permanent', 'deciduous', 'implant', 'pontic', 'saddle', 'missing', 'space closed', 'closed left', 'closed right')")]
        [Required]
        public ToothType tooth_type { get; set; } = ToothType.Permanent;

        public bool crown { get; set; } = false;

        public enum CrownType
        {
            Temporary,
            Metal,
            Gold,
            MetalCeramic,
            Ceramic,
            PlaningCrown
        }
        [Column(TypeName = "ENUM('temporary', 'metal', 'gold', 'metal ceramic', 'ceramic', 'planing crown')")]
        [Required]
        public CrownType crown_type { get; set; } = CrownType.MetalCeramic;
        public bool crown_insufficient { get; set; } = false;
        public bool rct { get; set; } = false;
        public RctType rct_type { get; set; } = RctType.RootFilling;
        public bool root_resection { get; set; } = false;
        public bool post { get; set; } = false;
        public PostType post_type { get; set; } = PostType.Metal;
        public bool ortho { get; set; } = false;
        public OrthoType ortho_type { get; set; } = OrthoType.Bracket;
        public bool vitality { get; set; } = false;
        public VitalityType vitality_type { get; set; } = VitalityType.Plus;
        public bool mobility { get; set; } = false;
        public MobilityType mobility_type { get; set; } = MobilityType.I;
        public FillingType filling_m_type { get; set; } = FillingType.Intact;
        public bool filling_m_foren { get; set; } = false;
        public bool filling_m_insufficient { get; set; } = false;
        public FillingType filling_d_type { get; set; } = FillingType.Intact;
        public bool filling_d_foren { get; set; } = false;
        public bool filling_d_insufficient { get; set; } = false;
        public FillingType filling_b_type { get; set; } = FillingType.Intact;
        public bool filling_b_foren { get; set; } = false;
        public bool filling_b_insufficient { get; set; } = false;
        public FillingType filling_l_type { get; set; } = FillingType.Intact;
        public bool filling_l_foren { get; set; } = false;
        public bool filling_l_insufficient { get; set; } = false;
        public FillingType filling_o_type { get; set; } = FillingType.Intact;
        public bool filling_o_foren { get; set; } = false;
        public bool filling_o_insufficient { get; set; } = false;
        public FillingType filling_c_type { get; set; } = FillingType.Intact;
        public bool filling_c_foren { get; set; } = false;
        public bool filling_c_insufficient { get; set; } = false;
        public PonticType pontic_type { get; set; } = PonticType.MetalCeramic;
        public bool pontic_insufficient { get; set; } = false;
        public MissingType missing_type { get; set; } = MissingType.None;
        public bool is_destroyed { get; set; } = false;
        public bool is_gum_recession { get; set; } = false;
        public bool is_abrasion { get; set; } = false;
        public bool is_fracture { get; set; } = false;
        public bool is_impacted { get; set; } = false;
        public bool is_erupting { get; set; } = false;
        public bool is_neck_defect { get; set; } = false;
        public bool is_sealed { get; set; } = false;
        public bool is_veneer { get; set; } = false;
        public bool is_foreign { get; set; } = false;
        public bool is_apical_lesion { get; set; } = false;
        public bool is_root_rest { get; set; } = false;
        public bool is_question { get; set; } = false;
    }
    public class SetTeethStatus
    {
        public TeethStatus teeth = new TeethStatus();
        public bool isPermanent { get; set; } = false;
        public bool isDeciduous { get; set; } = false;
        public bool isImolant { get; set; } = false;
        public bool isPontic { get; set; } = false;
        public bool isSaddle { get; set; } = false;
        public bool isMissing { get; set; } = false;
        public bool isSpaceClosed { get; set; } = false;
        public bool isClosedRight { get; set; } = false;
        public bool isClosedLeft { get; set; } = false;
        public void setToothType()
        {
            if (isPermanent)
            {
                teeth.tooth_type = ToothType.Permanent;
            }
            if (isDeciduous)
            {
                teeth.tooth_type = ToothType.Deciduous;
            }
            if (isImolant)
            {
                teeth.tooth_type = ToothType.Implant;
            }
            if (isPontic)
            {
                teeth.tooth_type = ToothType.Pontic;
            }
            if (isSaddle)
            {
                teeth.tooth_type = ToothType.Saddle;
            }
            if (isMissing)
            {
                teeth.tooth_type = ToothType.Missing;
            }
            if (isSpaceClosed)
            {
                teeth.tooth_type = ToothType.SpaceClosed;
            }
            if (isClosedRight)
            {
                teeth.tooth_type = ToothType.ClosedRight;
            }
            if (isClosedLeft)
            {
                teeth.tooth_type = ToothType.ClosedLeft;
            }
        }
    }
    public class SetCrownType
    {
        public TeethStatus teeth = new TeethStatus();
        public bool isTemporary { get; set; } = false;
        public bool ismetal { get; set; } = false;
        public bool isgold { get; set; } = false;
        public bool ismetalceramic { get; set; } = false;
        public bool isceramic { get; set; } = false;
        public bool isplaningCrown { get; set; } = false;
        public void setCrownType()
        {
            if (isTemporary)
            {
                teeth.crown_type = CrownType.Temporary;
            }
            if (ismetal)
            {
                teeth.crown_type = CrownType.Metal;
            }
            if (isgold)
            {
                teeth.crown_type = CrownType.Gold;
            }
            if (ismetalceramic)
            {
                teeth.crown_type = CrownType.MetalCeramic;
            }
            if (isceramic)
            {
                teeth.crown_type = CrownType.Ceramic;
            }
            if (isplaningCrown)
            {
                teeth.crown_type = CrownType.PlaningCrown;
            }
        }
    }
}