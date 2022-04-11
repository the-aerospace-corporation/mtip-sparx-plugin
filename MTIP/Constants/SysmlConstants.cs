/*
 * Copyright 2022 The Aerospace Corporation
 * 
 * Author: Karina Martinez
 * 
 * Description: Constants used for element and relationship types as well as SysML types found in 
 *              HUDS XML
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTIP.Constants
{
    public class SysmlConstants
    {
        //Categorization constants
        public static string ELEMENT = "Element";
        public static string RELATIONSHIP = "Relationship";
        public static string DIAGRAM = "Diagram";

        // Diagrams
        // ActivityDiagram
        // BlockDefinitionDiagram
        // InternalBlockDiagram
        // ClassDiagram
        // PackageDiagram
        // ParametricDiagram
        // ProfileDiagram
        // SequenceDiagram
        // StateMachineDiagram




        /* SYSML ACTIVITY ELEMENT CONSTANTS */
        public static string ACCEPTEVENTACTION = "AccepctEventAction";
        public static string ACTION = "Action";
        public static string ACTIVITY = "Activity";
        public static string ACTIVITYFINALNODE = "ActivityFinalNode";
        public static string ACTIVITYINITIALNODE = "InitialNode";
        public static string ACTIVITYPARAMETER = "ActivityParameter";
        public static string ACTIVITYPARAMETERNODE = "ActivityParameterNode"; // Sysml specifies as ActivityParameterNode
        public static string ACTIVITYPARTITION = "ActivityPartition";
        public static string CALLBEHAVIORACTION = "CallBehaviorAction";
        public static string CALLOBJECTACTION = "CreateObjectAction ";
        public static string CALLOPERATIONACTION = "CallOperationAction";
        public static string CENTRALBUFFERNODE = "CentralBufferNode";
        public static string CHANGE = "Change";
        public static string CONDITIONALNODE = "ConditionalNode";
        public static string CREATEOBJECTACTION = "CreateObjectAction";
        public static string DATASTORENODE = "DataStoreNode";
        public static string DECISION = "Decision";
        public static string DECISIONNODE = "DecisionNode";
        public static string DESTROYOBJECTACTION = "DestroyObjectAction";
        public static string EVENT = "Event";
        public static string FLOWFINALNODE = "FlowFinalNode";
        public static string FORK = "Fork";
        public static string FORKNODE = "ForkNode";
        public static string FORKVERTICAL = "ForkVertical";
        public static string FORKHORIZONTAL = "ForkHorizontal";
        public static string INITIALNODE = "InitialNode";
        public static string INPUTPIN = "InputPin";
        public static string INTERRUPTIBLEACTIVITYREGION = "InterruptibleActivityRegion";
        public static string JOIN = "Join";
        public static string JOINNODE = "JoinNode";
        public static string LOOPNODE = "LoopNode";
        public static string MERGENODE = "MergeNode";
        public static string OBJECT = "Object";
        public static string OBJECTNODE = "ObjectNode";
        public static string OPAQUEACTION = "OpaqueAction";
        public static string OPAQUEEXPRESSION = "OpaqueExpression";
        public static string OUTPUTPIN = "OutputPin";
        // Parameter (Defined in cameo but no match currently found in EA)
        public static string SENDSIGNALACTION = "SendSignalAction";
        public static string SYNCHRONIZATION = "Synchronization";
        // TimeEvent (Defined in cameo but no match currently found in EA)
        // TimeExpression (Defined in cameo but no match currently found in EA)

        /* SYSML BLOCK DEFINITION ELEMENT CONSTANTS */
        public static string ASSOCIATIONBLOCK = "AssociationBlock";
        public static string BLOCK = "Block";
        public static string CONSTRAINT = "Constraint";
        public static string CONSTRAINTBLOCK = "ConstraintBlock";
        public static string DOMAIN = "Domain";
        public static string ENUMERATION = "Enumeration";
        public static string EXTERNAL = "External";
        public static string FLOWPORT = "FlowPort";
        public static string FLOWSPECIFICATION = "FlowSpecification";
        public static string FULLPORT = "FullPort";
        public static string INFORMATIONITEM = "InformationItem";
        public static string INSTANCESPECIFICATION = "InstanceSpecification";
        public static string INTERFACE = "Interface";
        public static string INTERFACEBLOCK = "InterfaceBlock";
        // Link (Defined in cameo but no match currently found in EA)
        public static string NOTE = "Note";
        public static string OPERATION = "Operation";
        public static string PARTPROPERTY = "PartProperty";
        public static string PORT = "Port";
        public static string PROXYPORT = "ProxyPort";
        public static string QUANTITYKIND = "QuantityKind";
        public static string SIGNAL = "Signal";
        // Slot (Defined in cameo but no match currently found in EA)
        public static string SUBSYSTEM = "Subsystem";
        public static string SYSTEM = "System";
        public static string SYSTEMCONTEXT = "SystemContext";
        public static string UNIT = "Unit";
        public static string VALUEPROPERTY = "ValueProperty";
        public static string VALUETYPE = "ValueType";

        /* SYSML INTERNAL BLOCK ELEMENT CONSTANTS */
        public static string BOUNDREFERENCE = "BoundReference";
        public static string CLASSIFIERBEHAVIORPROPERTY = "ClassifierBehaviorProperty";
        public static string CONSTRAINTPARAMETER = "ConstraintParameter";
        public static string CONSTRAINTPROPERTY = "ConstraintProperty";
        public static string FLOWPROPERTY = "FlowProperty";
        public static string PARTICIPANTPROPERTY = "ParticipantProperty";
        public static string REFERENCEPROPERTY = "ReferenceProperty";
        public static string REQUIREDINTERFACE = "RequiredInterface"; // Currently not used

        /* SYSML PROFILE ELEMENT CONSTANTS */
        public static string CLASS = "Class";
        // Constraint (Defined in BDD types)
        public static string PART = "Part";
        // Customization (Defined in cameo but no match currently found in EA)
        public static string METACLASS = "Metaclass";
        // OpaqueExpression (Defined in BDD types)
        public static string PROFILE = "Profile";
        public static string RELATIONSHIPCONSTRAINT = "RelationshipConstraint";
        public static string STEREOTYPE = "Stereotype";
        // Term (Defined in cameo but no match currently found in EA)

        /* SYSML REQUIREMENT ELEMENT CONSTANTS */
        public static string DESIGNCONSTRAINT = "DesignConstraint";
        public static string EXTENDEDREQUIREMENT = "ExtendedRequirement";
        public static string FUNCTIONALREQUIREMENT = "FunctionalRequirement";
        public static string INTERFACEREQUIREMENT = "InterfaceRequirement";
        public static string PERFORMANCEREQUIREMENT = "PerformanceRequirement";
        public static string PHYSICALREQUIREMENT = "PhysicalRequirement";
        public static string REQUIREMENT = "Requirement";

        /* SYSML SEQUENCE ELEMENT CONSTANTS */
        public static string COLLABORATION = "Collaboration";
        public static string COMBINEDFRAGMENT = "CombinedFragment";
        // DestructionOccurrenceSpecification (Defined in cameo but no match currently found in EA)
        // DurationConstraint (Defined in cameo but no match currently found in EA)
        // DurationObservation (Defined in cameo but no match currently found in EA)
        public static string INTERACTION = "Interaction";
        // InteractionOperand (Defined in cameo but no match currently found in EA)
        // InteractionUse (Defined in cameo but no match currently found in EA)
        public static string LIFELINE = "Lifeline";
        // MessageOccurrenceSpecification (Defined in cameo but no match currently found in EA)
        public static string PROPERTY = "Property";
        public static string INTERACTIONSTATE = "InteractionState";
        public static string STATEINVARIANT = "StateInvariant";
        // TimeConstraint (Defined in cameo but no match currently found in EA)
        // TimeObservation (Defined in cameo but no match currently found in EA)

        /* SYSML STATE MACHINE ELEMENT CONSTANTS */
        public static string CHOICEPSUEDOSTATE = "ChoicePseudoState";
        // ConnectionPointReference (Defined in cameo but no match currently found in EA)
        public static string DEEPHISTORY = "DeepHistory";
        public static string ENTRYPOINT = "EntryPoint";
        public static string EXITPOINT = "ExitPoint";
        public static string FINALSTATE = "FinalState";
        // Fork (Defined in Activity types)
        // FunctionalBehavior (Defined in cameo but no match currently found in EA)
        public static string INITIALPSEUDOSTATE = "InitialPseudoState";
        // Join (Defined in Activity types)
        // OpaqueBehavior  (Defined in cameo but no match currently found in EA)
        public static string STATENODE = "StateNode";
        public static string REGION = "Region";
        public static string SHALLOWHISTORY = "ShallowHistory";
        /* Need to get back to this cameo creates a trigger for the signal*/
        // public static string SIGNALEVENT = "SignalEvent";
        public static string STATE = "State";
        public static string STATEMACHINE = "StateMachine";
        public static string TERMINATE = "Terminate";
        public static string TRIGGER = "Trigger";

        /* SYSML USE CASE ELEMENT CONSTANTS */
        public static string ACTOR = "Actor";
        public static string USECASE = "UseCase";
        public static string BOUNDARY = "Boundary";


        public static string ACTIONPIN = "ActionPin";
        public static string BUSINESSREQUIREMENT = "BusinessRequirement";
        public static string CLASSIFICATION = "Classification";
        public static string EXCEPTIONHANDLER = "ExceptionHandler";
        public static string HYPERLINK = "Hyperlink";
        public static string INTERACTIONFRAGMENT = "InteractionFragment";
        public static string INTERACTIONUSE = "InteractionUse";
        public static string MODEL = "Model";
        public static string OBJECTIVEFUNCTION = "ObjectiveFunction";
        public static string PACKAGE = "Package";
        public static string TEXT = "Text";

        // EA Constants
        public static string NAVIGATIONCELL = "NavigationCell";

        //	public static string NOTE = "Note";
        //	public static string PROFILE = "Profile";
        //	public static string PARAMETER = "Parameter";

        //Sysml Relationship Constants

        // Activity relationships
        public static string CONTROLFLOW = "ControlFlow";
        public static string OBJECTFLOW = "ObjectFlow";

        // BBD Relationships
        // Realization/Realisation/InterfaceRealization
        public static string REALIZATION = "Realization";
        public static string REALISATION = "Realisation";

        // IBD Relationships
        public static string BINDINGCONNECTOR = "BindingConnector";
        public static string CONNECTOR = "Connector";
        public static string INFORMATIONFLOW = "InformationFlow";
        public static string ITEMFLOW = "ItemFlow";

        // Profile Relationships
        public static string EXTENSION = "Extension";

        // Requirement Replationships
        public static string COPY = "Copy";
        public static string DERIVEREQUIREMENT = "DeriveRequirement";
        public static string REFINE = "Refine";
        public static string SATISFY = "Satisfy";
        public static string TRACE = "Trace";
        public static string VERIFY = "Verify";

        // Sequence Relationships
        public static string MESSAGE = "Message";
        public static string TRANSITION = "Transition";

        // Use Case Relationships
        public static string EXTEND = "Extend";
        public static string INCLUDE = "Include ";


        public static string ABSTRACTION = "Abstraction";
        public static string AGGREGATION = "Aggregation";
        public static string ALLOCATE = "Allocate";
        public static string ARTIFACT = "Artifact";
        public static string ASSOCIATION = "Association";
        public static string COMPOSITION = "Composition";
        public static string DEPENDENCY = "Dependency";
        public static string GENERALIZATION = "Generalization";
        public static string INTERRUPTFLOW = "InterruptFlow";
        public static string NESTING = "Nesting";
        public static string PARTASSOCIATION = "PartAssociation";
        public static string SEQUENCE = "Sequence";
        public static string STATEFLOW = "StateFlow";
        public static string USECASERELATIONSHIP = "UseCaseRelationship";
        public static string USAGE = "Usage";


        //Sysml Diagram constants
        public static string BDD = "BlockDefinitionDiagram";
        public static string IBD = "InternalBlockDiagram";
        public static string PKG = "PackageDiagram";
        public static string REQ = "RequirementsDiagram";
        public static string PAR = "ParametricDiagram";
        public static string STM = "StateMachineDiagram";
        public static string ACT = "ActivityDiagram";
        public static string SEQ = "SequenceDiagram";
        public static string UC = "UseCaseDiagram";

        public static string SYSMLACCEPTEVENTACTION = "sysml.AcceptEventAction";
        public static string SYSMLACTIVITY = "sysml.Activity";
        public static string SYSMLACTION = "sysml.Action";
        public static string SYSMLACTIONPIN = "sysml.ActionPin";
        public static string SYSMLACTIVITYFINALNODE = "sysml.ActivityFinalNode";
        public static string SYSMLACTIVITYPARAMETER = "sysml.ActivityParameter";
        public static string SYSMLACTIVITYPARAMETERNODE = "sysml.ActivityParameterNode";
        public static string SYSMLACTOR = "sysml.Actor";
        public static string SYSMLACTIVITYPARTITION = "sysml.ActivityPartition";
        public static string SYSMLALLOCATED = "sysml.Allocated";
        public static string SYSMLARTIFACT = "sysml.Artifact";
        public static string SYSMLBLOCK = "sysml.Block";
        public static string SYSMLBOUNDREFERENCE = "sysml.BoundReference";
        public static string SYSMLBOUNDARY = "sysml.Boundary";
        public static string SYSMLCALLBEHAVIORACTION = "sysml.CallBehaviorAction";
        public static string SYSMLCALLOPERATIONACTION = "sysml.CallOperationAction";
        public static string SYSMLCENTRALBUFFERNODE = "sysml.CentralBufferNode";
        public static string SYSMLCHANGE = "sysml.ChangeEvent";
        public static string SYSMLCHOICEPSEUDOSTATE = "sysml.ChoicePseudoState";
        public static string SYSMLCLASS = "sysml.Class";
        public static string SYSMLCLASSIFICATION = "sysml.Classification";
        public static string SYSMLCLASSIFIERBEHAVIORPROPERTY = "sysml.ClassifierBehaviorProperty";
        public static string SYSMLCOLLABORATION = "sysml.Collaboration";
        public static string SYSMLCOMBINEDFRAGMENT = "sysml.CombinedFragment";
        public static string SYSMLCONDITIONALNODE = "sysml.ConditionalNode";
        public static string SYSMLCONSTRAINT = "sysml.Constraint";
        public static string SYSMLCONSTRAINTBLOCK = "sysml.ConstraintBlock";
        public static string SYSMLCONSTRAINTPROPERTY = "sysml.ConstraintProperty";
        public static string SYSMLCONSTRAINTPARAMETER = "sysml.ConstraintParameter";
        public static string SYSMLCREATEOBJECTACTION = "sysml.CreateObjectAction";
        public static string SYSMLDATASTORENODE = "sysml.DataStoreNode";
        public static string SYSMLDECISIONNODE = "sysml.DecisionNode";
        public static string SYSMLDEEPHISTORY = "sysml.DeepHistory";
        public static string SYSMLDESIGNCONSTRAINT = "sysml.DesignConstraint";
        public static string SYSMLDESTROYOBJECTACTION = "sysml.DestroyObjectAction";
        public static string SYSMLFLOWPORT = "sysml.FlowPort";
        public static string SYSMLENTRYPOINT = "sysml.EntryPoint";
        public static string SYSMLENUMERATION = "sysml.Enumeration";
        public static string SYSMLEVENT = "sysml.Event";
        public static string SYSMLEXCEPTIONHANDLER = "sysml.ExceptionHandler";
        public static string SYSMLEXTENDEDREQUIREMENT = "sysml.ExtendedRequirement";
        public static string SYSMLEXITPOINT = "sysml.ExitPoint";
        public static string SYSMLFINALSTATE = "sysml.FinalState";
        public static string SYSMLFLOWPROPERTY = "sysml.FlowProperty";
        public static string SYSMLFLOWFINALNODE = "sysml.FlowFinalNode";
        public static string SYSMLFLOWSPECIFICATION = "sysml.FlowSpecification";
        public static string SYSMLFUNCTIONALREQUIREMENT = "sysml.FunctionalRequirement";
        public static string SYSMLFULLPORT = "sysml.FullPort";
        public static string SYSMLFORK = "sysml.Fork";
        public static string SYSMLFORKNODE = "sysml.ForkNode";
        public static string SYSMLHYPERLINK = "sysml.Hyperlink";
        public static string SYSMLINITIALNODE = "sysml.InitialNode";
        public static string SYSMLINFORMATIONITEM = "sysml.InformationItem";
        public static string SYSMLINITIALPSEUDOSTATE = "sysml.InitialPseudoState";
        public static string SYSMLINSTANCESPECIFICATION = "sysml.InstanceSpecification";
        public static string SYSMLINPUTPIN = "sysml.InputPin";
        public static string SYSMLINTERACTION = "sysml.Interaction";
        public static string SYSMLINTERFACE = "sysml.Interface";
        public static string SYSMLINTERFACEBLOCK = "sysml.InterfaceBlock";
        public static string SYSMLINTERFACEREQUIREMENT = "sysml.InterfaceRequirement";
        public static string SYSMLINTERRUPTIBLEACTIVITYREGION = "sysml.InterruptibleActivityRegion";
        public static string SYSMLJOIN = "sysml.Join";
        public static string SYSMLJOINNODE = "sysml.JoinNode";
        public static string SYSMLLIFELINE = "sysml.Lifeline";
        public static string SYSMLLOOPNODE = "sysml.LoopNode";
        public static string SYSMLMERGENODE = "sysml.MergeNode";
        public static string SYSMLMESSAGE = "sysml.Message";
        public static string SYSMLMETACLASS = "sysml.Metaclass";
        public static string SYSMLMODEL = "sysml.Model";
        public static string SYSMLMODELIBRARY = "sysml.ModelLibrary";
        public static string SYSMLOBJECT = "sysml.Object";
        public static string SYSMLNOTE = "sysml.Note";
        public static string SYSMLOBJECTFLOW = "sysml.ObjectFlow";
        public static string SYSMLOBJECTNODE = "sysml.ObjectNode";
        public static string SYSMLOBJECTIVEFUNCTION = "sysml.ObjectiveFunction";
        public static string SYSMLOPAQUEACTION = "sysml.OpaqueAction";
        public static string SYSMLOPAQUEEXPRESSION = "sysml.OpaqueExpression";
        public static string SYSMLOUTPUTPIN = "sysml.OutputPin";
        public static string SYSMLPACKAGE = "sysml.Package";
        public static string SYSMLPARTICIPANTPROPERTY = "sysml.ParticipantProperty";
        public static string SYSMLPARTPROPERTY = "sysml.PartProperty";
        public static string SYSMLPERFORMANCEREQUIREMENT = "sysml.PerformanceRequirement";
        public static string SYSMLPHYSICALREQUIREMENT = "sysml.PhysicalRequirement";
        public static string SYSMLPORT = "sysml.Port";
        public static string SYSMLPROFILE = "sysml.Profile";
        public static string SYSMLPROXYPORT = "sysml.ProxyPort";
        public static string SYSMLREGION = "sysml.Region";
        public static string SYSMLREQUIREDINTERFACE = "sysml.RequiredInterface";
        public static string SYSMLREQUIREMENT = "sysml.Requirement";
        public static string SYSMLSENDSIGNALACTION = "sysml.SendSignalAction";
        public static string SYSMLSHALLOWHISTORY = "sysml.ShallowHistory";
        public static string SYSMLSIGNAL = "sysml.Signal";
        public static string SYSMLSTATE = "sysml.State";
        public static string SYSMLSTATEINVARIANT = "sysml.StateInvariant";
        public static string SYSMLSTATEMACHINE = "sysml.StateMachine";
        public static string SYSMLSTEREOTYPE = "sysml.Stereotype";
        public static string SYSMLSTRUCTUREDACTIVITYACTION = "sysml.StructuredActivityNode";
        public static string SYSMLSYNCHRONIZATION = "sysml.Synchronization";
        public static string SYSMLTERMINATE = "sysml.Terminate";
        public static string SYSMLTEXT = "sysml.Text";
        public static string SYSMLTRIGGER = "sysml.Trigger";
        public static string SYSMLUSECASE = "sysml.UseCase";
        public static string SYSMLVALUEPROPERTY = "sysml.ValueProperty";
        public static string SYSMLVALUETYPE = "sysml.ValueType";

        public static string EANAVIGATIONCELL = "ea.NavigationCell";

        public static string SYSMLABSTRACTION = "sysml.Abstraction";
        public static string SYSMLAGGREGATION = "sysml.Aggregation";
        public static string SYSMLASSOCIATION = "sysml.Association";
        public static string SYSMLASSOCIATIONBLOCK = "sysml.AssociationBlock";
        public static string SYSMLCOMPOSITION = "sysml.Composition";
        public static string SYSMLCONNECTOR = "sysml.Connector";
        public static string SYSMLCONTROLFLOW = "sysml.ControlFlow";
        public static string SYSMLDEPENDENCY = "sysml.Dependency";
        public static string SYSMLEXTENSION = "sysml.Extension";
        public static string SYSMLGENERALIZATION = "sysml.Generalization";
        public static string SYSMLINFORMATIONFLOW = "sysml.InformationFlow";
        public static string SYSMLINCLUDE = "sysml.Include";
        public static string SYSMLITEMFLOW = "sysml.ItemFlow";
        public static string SYSMLINTERRUPTFLOW = "sysml.InterruptFlow";
        public static string SYSMLNESTING = "sysml.Nesting";
        public static string SYSMLREALIZATION = "sysml.Realization";
        public static string SYSMLTRANSITION = "sysml.Transition";
        public static string SYSMLUSAGE = "sysml.Usage";
        public static string SYSMLUSECASERELATIONSHIP = "sysml.UseCaseRelationship";

        public static string SYSMLACTIVITYDIAGRAM = "sysml.ActivityDiagram";
        public static string SYSMLBLOCKDEFINITIONDIAGRAM = "sysml.BlockDefinitionDiagram";
        public static string SYSMLINTERNALBLOCKDIAGRAM = "sysml.InternalBlockDiagram";
        public static string SYSMLPACKAGEDIAGRAM = "sysml.PackageDiagram";
        public static string SYSMLPARAMETRICDIAGRAM = "sysml.ParametricDiagram";
        public static string SYSMLREQUIREMENTSDIAGRAM = "sysml.RequirementsDiagram";
        public static string SYSMLSEQUENCEDIAGRAM = "sysml.SequenceDiagram";
        public static string SYSMLSTATEMACHINEDIAGRAM = "sysml.StateMachineDiagram";
        public static string SYSMLUSECASEDIAGRAM = "sysml.UseCaseDiagram";

        public static string[] SYSMLELEMENTS = {
            ACCEPTEVENTACTION,
            ACTION,
            ACTIONPIN,
            ACTIVITY,
            ACTIVITYINITIALNODE,
            ACTIVITYFINALNODE,
            ACTIVITYPARAMETERNODE, // Sysml specifies as ActivityParameterNode
            ACTIVITYPARTITION,
            ACTOR,
            BLOCK,
            BOUNDARY,
            BUSINESSREQUIREMENT,
            CALLBEHAVIORACTION,
            CALLOPERATIONACTION,
            CENTRALBUFFERNODE,
            CHOICEPSUEDOSTATE,
            CHANGE,
            CLASS,
            CLASSIFICATION,
            CLASSIFIERBEHAVIORPROPERTY,
            COLLABORATION,
            COMBINEDFRAGMENT,
            CONDITIONALNODE,
            CONSTRAINT,
            CONSTRAINTBLOCK,
            CONSTRAINTPARAMETER,
            CREATEOBJECTACTION,
            CALLOPERATIONACTION,
            DATASTORENODE,
            DECISION,
            DECISIONNODE,
            DESIGNCONSTRAINT,
            DESTROYOBJECTACTION,
            EXCEPTIONHANDLER,
            DOMAIN,
            ENTRYPOINT,
            ENUMERATION,
            EVENT,
            EXITPOINT,
            EXTERNAL,
            EXTENDEDREQUIREMENT,
            FINALSTATE,
            FLOWFINALNODE,
            FLOWPORT,
            FLOWPROPERTY,
            FLOWSPECIFICATION,
            FORK,
            FORKVERTICAL,
            FORKHORIZONTAL,
            FORKNODE,
            FULLPORT,
            FUNCTIONALREQUIREMENT,
            HYPERLINK,
            INFORMATIONITEM,
            INSTANCESPECIFICATION,
            INTERACTION,
            INTERACTIONFRAGMENT,
            INTERACTIONSTATE,
            INTERACTIONUSE,
            INTERFACE,
            INTERFACEBLOCK,
            INTERFACEREQUIREMENT,
            INITIALNODE,
            INITIALPSEUDOSTATE,
            INTERRUPTIBLEACTIVITYREGION,
            INPUTPIN,
            JOINNODE,
            JOIN,
            LIFELINE,
            LOOPNODE,
            METACLASS,
            MERGENODE,
            MODEL,
            NOTE,
            OBJECT,
            OBJECTNODE,
            OBJECTIVEFUNCTION,
            OPERATION,
            OPAQUEACTION,
            OPAQUEEXPRESSION,
            OUTPUTPIN,
            PACKAGE,
            PARTPROPERTY,
            PERFORMANCEREQUIREMENT,
            PHYSICALREQUIREMENT,
            PART,
            PORT,
            PROFILE,
            PROPERTY,
            PROXYPORT,
            QUANTITYKIND,
            REQUIREDINTERFACE,
            REQUIREMENT,
            REGION,
            SENDSIGNALACTION,
            SIGNAL,
            STATE,
            STATEINVARIANT,
            STATENODE,
            STATEMACHINE,
            STEREOTYPE,
            SUBSYSTEM,
            SYNCHRONIZATION,
            SYSTEM,
            SYSTEMCONTEXT,
            TERMINATE,
            TEXT,
            TRIGGER,
            UNIT,
            USECASE,
            VALUEPROPERTY,
            VALUETYPE,
            RELATIONSHIPCONSTRAINT,
            REFERENCEPROPERTY,
            CONSTRAINTPROPERTY,
            BOUNDREFERENCE,
            PARTICIPANTPROPERTY,


            // EA Elements
            NAVIGATIONCELL
    };

        public static string[] SYSMLRELATIONSHIPS = {
                ABSTRACTION,
                AGGREGATION,
                ALLOCATE,
                ASSOCIATION,
                ASSOCIATIONBLOCK,
                COMPOSITION,
                CONNECTOR,
                CONTROLFLOW,
                COPY,
                DEPENDENCY,
                DERIVEREQUIREMENT,
                EXTEND,
                EXTENSION,
                GENERALIZATION,
                INCLUDE,
                INFORMATIONFLOW,
                INTERRUPTFLOW,
                ITEMFLOW,
                MESSAGE,
                NESTING,
                PARTASSOCIATION,
                REALISATION,
                REALIZATION,
                RELATIONSHIPCONSTRAINT,
                REFINE,
                SATISFY,
                SEQUENCE,
                TRACE,
                TRANSITION,
                USAGE,
                USECASERELATIONSHIP,
                VERIFY,
                OBJECTFLOW,
                BINDINGCONNECTOR
    };

        public static string[] SYSMLDIAGRAMS = {
                BDD,
                IBD,
                STM,
                ACT,
                PKG,
                REQ,
                PAR,
                SEQ,
                UC
        };
    }
}
