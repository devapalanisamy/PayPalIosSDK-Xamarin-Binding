using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace PayPalIosBinding
{
	// @interface PayPalConfiguration : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface PayPalConfiguration : INSCopying
	{
		// @property (readwrite, copy, nonatomic) NSString * defaultUserEmail;
		[Export ("defaultUserEmail")]
		string DefaultUserEmail { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * defaultUserPhoneCountryCode;
		[Export ("defaultUserPhoneCountryCode")]
		string DefaultUserPhoneCountryCode { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * defaultUserPhoneNumber;
		[Export ("defaultUserPhoneNumber")]
		string DefaultUserPhoneNumber { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * merchantName;
		[Export ("merchantName")]
		string MerchantName { get; set; }

		// @property (readwrite, copy, nonatomic) NSURL * merchantPrivacyPolicyURL;
		[Export ("merchantPrivacyPolicyURL", ArgumentSemantic.Copy)]
		NSUrl MerchantPrivacyPolicyURL { get; set; }

		// @property (readwrite, copy, nonatomic) NSURL * merchantUserAgreementURL;
		[Export ("merchantUserAgreementURL", ArgumentSemantic.Copy)]
		NSUrl MerchantUserAgreementURL { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL acceptCreditCards;
		[Export ("acceptCreditCards")]
		bool AcceptCreditCards { get; set; }

		// @property (assign, readwrite, nonatomic) PayPalShippingAddressOption payPalShippingAddressOption;
		[Export ("payPalShippingAddressOption", ArgumentSemantic.Assign)]
		PayPalShippingAddressOption PayPalShippingAddressOption { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL rememberUser;
		[Export ("rememberUser")]
		bool RememberUser { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * languageOrLocale;
		[Export ("languageOrLocale")]
		string LanguageOrLocale { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL alwaysDisplayCurrencyCodes;
		[Export ("alwaysDisplayCurrencyCodes")]
		bool AlwaysDisplayCurrencyCodes { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL disableBlurWhenBackgrounding;
		[Export ("disableBlurWhenBackgrounding")]
		bool DisableBlurWhenBackgrounding { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL presentingInPopover;
		[Export ("presentingInPopover")]
		bool PresentingInPopover { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL forceDefaultsInSandbox;
		[Export ("forceDefaultsInSandbox")]
		bool ForceDefaultsInSandbox { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * sandboxUserPassword;
		[Export ("sandboxUserPassword")]
		string SandboxUserPassword { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * sandboxUserPin;
		[Export ("sandboxUserPin")]
		string SandboxUserPin { get; set; }
	}

	// typedef void (^PayPalFuturePaymentDelegateCompletionBlock)();
	delegate void PayPalFuturePaymentDelegateCompletionBlock ();

	// @protocol PayPalFuturePaymentDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PayPalFuturePaymentDelegate
	{
		// @required -(void)payPalFuturePaymentDidCancel:(PayPalFuturePaymentViewController *)futurePaymentViewController;
		[Abstract]
		[Export ("payPalFuturePaymentDidCancel:")]
		void PayPalFuturePaymentDidCancel (PayPalFuturePaymentViewController futurePaymentViewController);

		// @required -(void)payPalFuturePaymentViewController:(PayPalFuturePaymentViewController *)futurePaymentViewController didAuthorizeFuturePayment:(NSDictionary *)futurePaymentAuthorization;
		[Abstract]
		[Export ("payPalFuturePaymentViewController:didAuthorizeFuturePayment:")]
		void PayPalFuturePaymentViewController (PayPalFuturePaymentViewController futurePaymentViewController, NSDictionary futurePaymentAuthorization);

		// @optional -(void)payPalFuturePaymentViewController:(PayPalFuturePaymentViewController *)futurePaymentViewController willAuthorizeFuturePayment:(NSDictionary *)futurePaymentAuthorization completionBlock:(PayPalFuturePaymentDelegateCompletionBlock)completionBlock;
		[Export ("payPalFuturePaymentViewController:willAuthorizeFuturePayment:completionBlock:")]
		void PayPalFuturePaymentViewController (PayPalFuturePaymentViewController futurePaymentViewController, NSDictionary futurePaymentAuthorization, PayPalFuturePaymentDelegateCompletionBlock completionBlock);
	}

	// @interface PayPalFuturePaymentViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface PayPalFuturePaymentViewController
	{
		// -(instancetype)initWithConfiguration:(PayPalConfiguration *)configuration delegate:(id<PayPalFuturePaymentDelegate>)del;
		[Export ("initWithConfiguration:delegate:")]
		IntPtr Constructor (PayPalConfiguration configuration, PayPalFuturePaymentDelegate @del);

		[Wrap ("WeakFuturePaymentDelegate")]
		PayPalFuturePaymentDelegate FuturePaymentDelegate { get; }

		// @property (readonly, nonatomic, weak) id<PayPalFuturePaymentDelegate> futurePaymentDelegate;
		[NullAllowed, Export ("futurePaymentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakFuturePaymentDelegate { get; }
	}

	//[Verify (ConstantsInterfaceAssociation)]
	partial interface PaymentConstants
	{
		// extern NSString *const kPayPalOAuth2ScopeFuturePayments;
		[Field ("kPayPalOAuth2ScopeFuturePayments")]
		NSString kPayPalOAuth2ScopeFuturePayments { get; }

		// extern NSString *const kPayPalOAuth2ScopeProfile;
		[Field ("kPayPalOAuth2ScopeProfile")]
		NSString kPayPalOAuth2ScopeProfile { get; }

		// extern NSString *const kPayPalOAuth2ScopeOpenId;
		[Field ("kPayPalOAuth2ScopeOpenId")]
		NSString kPayPalOAuth2ScopeOpenId { get; }

		// extern NSString *const kPayPalOAuth2ScopePayPalAttributes;
		[Field ("kPayPalOAuth2ScopePayPalAttributes")]
		NSString kPayPalOAuth2ScopePayPalAttributes { get; }

		// extern NSString *const kPayPalOAuth2ScopeEmail;
		[Field ("kPayPalOAuth2ScopeEmail")]
		NSString kPayPalOAuth2ScopeEmail { get; }

		// extern NSString *const kPayPalOAuth2ScopeAddress;
		[Field ("kPayPalOAuth2ScopeAddress")]
		NSString kPayPalOAuth2ScopeAddress { get; }

		// extern NSString *const kPayPalOAuth2ScopePhone;
		[Field ("kPayPalOAuth2ScopePhone")]
		NSString kPayPalOAuth2ScopePhone { get; }
	}

	// @interface PayPalPaymentDetails : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface PayPalPaymentDetails : INSCopying
	{
		// +(PayPalPaymentDetails *)paymentDetailsWithSubtotal:(NSDecimalNumber *)subtotal withShipping:(NSDecimalNumber *)shipping withTax:(NSDecimalNumber *)tax;
		[Static]
		[Export ("paymentDetailsWithSubtotal:withShipping:withTax:")]
		PayPalPaymentDetails PaymentDetailsWithSubtotal (NSDecimalNumber subtotal, NSDecimalNumber shipping, NSDecimalNumber tax);

		// @property (readwrite, copy, nonatomic) NSDecimalNumber * subtotal;
		[Export ("subtotal", ArgumentSemantic.Copy)]
		NSDecimalNumber Subtotal { get; set; }

		// @property (readwrite, copy, nonatomic) NSDecimalNumber * shipping;
		[Export ("shipping", ArgumentSemantic.Copy)]
		NSDecimalNumber Shipping { get; set; }

		// @property (readwrite, copy, nonatomic) NSDecimalNumber * tax;
		[Export ("tax", ArgumentSemantic.Copy)]
		NSDecimalNumber Tax { get; set; }
	}

	// @interface PayPalItem : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface PayPalItem : INSCopying
	{
		// +(PayPalItem *)itemWithName:(NSString *)name withQuantity:(NSUInteger)quantity withPrice:(NSDecimalNumber *)price withCurrency:(NSString *)currency withSku:(NSString *)sku;
		[Static]
		[Export ("itemWithName:withQuantity:withPrice:withCurrency:withSku:")]
		PayPalItem ItemWithName (string name, nuint quantity, NSDecimalNumber price, string currency, string sku);

		// +(NSDecimalNumber *)totalPriceForItems:(NSArray *)items;
		[Static]
		[Export ("totalPriceForItems:")]
		//[Verify (StronglyTypedNSArray)]
		NSDecimalNumber TotalPriceForItems (NSObject[] items);

		// @property (readwrite, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (assign, readwrite, nonatomic) NSUInteger quantity;
		[Export ("quantity", ArgumentSemantic.Assign)]
		nuint Quantity { get; set; }

		// @property (readwrite, copy, nonatomic) NSDecimalNumber * price;
		[Export ("price", ArgumentSemantic.Copy)]
		NSDecimalNumber Price { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * currency;
		[Export ("currency")]
		string Currency { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * sku;
		[Export ("sku")]
		string Sku { get; set; }
	}

	// @interface PayPalShippingAddress : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface PayPalShippingAddress : INSCopying
	{
		// +(PayPalShippingAddress *)shippingAddressWithRecipientName:(NSString *)recipientName withLine1:(NSString *)line1 withLine2:(NSString *)line2 withCity:(NSString *)city withState:(NSString *)state withPostalCode:(NSString *)postalCode withCountryCode:(NSString *)countryCode;
		[Static]
		[Export ("shippingAddressWithRecipientName:withLine1:withLine2:withCity:withState:withPostalCode:withCountryCode:")]
		PayPalShippingAddress ShippingAddressWithRecipientName (string recipientName, string line1, string line2, string city, string state, string postalCode, string countryCode);

		// @property (readwrite, copy, nonatomic) NSString * recipientName;
		[Export ("recipientName")]
		string RecipientName { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * line1;
		[Export ("line1")]
		string Line1 { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * line2;
		[Export ("line2")]
		string Line2 { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * city;
		[Export ("city")]
		string City { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * state;
		[Export ("state")]
		string State { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * postalCode;
		[Export ("postalCode")]
		string PostalCode { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * countryCode;
		[Export ("countryCode")]
		string CountryCode { get; set; }
	}

	// @interface PayPalPayment : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface PayPalPayment : INSCopying
	{
		// +(PayPalPayment *)paymentWithAmount:(NSDecimalNumber *)amount currencyCode:(NSString *)currencyCode shortDescription:(NSString *)shortDescription intent:(PayPalPaymentIntent)intent;
		[Static]
		[Export ("paymentWithAmount:currencyCode:shortDescription:intent:")]
		PayPalPayment PaymentWithAmount (NSDecimalNumber amount, string currencyCode, string shortDescription, PayPalPaymentIntent intent);

		// @property (readwrite, copy, nonatomic) NSString * currencyCode;
		[Export ("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (readwrite, copy, nonatomic) NSDecimalNumber * amount;
		[Export ("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * shortDescription;
		[Export ("shortDescription")]
		string ShortDescription { get; set; }

		// @property (assign, readwrite, nonatomic) PayPalPaymentIntent intent;
		[Export ("intent", ArgumentSemantic.Assign)]
		PayPalPaymentIntent Intent { get; set; }

		// @property (readwrite, copy, nonatomic) PayPalPaymentDetails * paymentDetails;
		[Export ("paymentDetails", ArgumentSemantic.Copy)]
		PayPalPaymentDetails PaymentDetails { get; set; }

		// @property (readwrite, copy, nonatomic) NSArray * items;
		[Export ("items", ArgumentSemantic.Copy)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Items { get; set; }

		// @property (readwrite, copy, nonatomic) PayPalShippingAddress * shippingAddress;
		[Export ("shippingAddress", ArgumentSemantic.Copy)]
		PayPalShippingAddress ShippingAddress { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * invoiceNumber;
		[Export ("invoiceNumber")]
		string InvoiceNumber { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * custom;
		[Export ("custom")]
		string Custom { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * softDescriptor;
		[Export ("softDescriptor")]
		string SoftDescriptor { get; set; }

		// @property (readwrite, copy, nonatomic) NSString * bnCode;
		[Export ("bnCode")]
		string BnCode { get; set; }

		// @property (readonly, assign, nonatomic) BOOL processable;
		[Export ("processable")]
		bool Processable { get; }

		// @property (readonly, copy, nonatomic) NSString * localizedAmountForDisplay;
		[Export ("localizedAmountForDisplay")]
		string LocalizedAmountForDisplay { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * confirmation;
		[Export ("confirmation", ArgumentSemantic.Copy)]
		NSDictionary Confirmation { get; }
	}

	// typedef void (^PayPalPaymentDelegateCompletionBlock)();
	delegate void PayPalPaymentDelegateCompletionBlock ();

	// @protocol PayPalPaymentDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PayPalPaymentDelegate
	{
		// @required -(void)payPalPaymentDidCancel:(PayPalPaymentViewController *)paymentViewController;
		[Abstract]
		[Export ("payPalPaymentDidCancel:")]
		void PayPalPaymentDidCancel (PayPalPaymentViewController paymentViewController);

		// @required -(void)payPalPaymentViewController:(PayPalPaymentViewController *)paymentViewController didCompletePayment:(PayPalPayment *)completedPayment;
		[Abstract]
		[Export ("payPalPaymentViewController:didCompletePayment:")]
		void PayPalPaymentViewController (PayPalPaymentViewController paymentViewController, PayPalPayment completedPayment);

		// @optional -(void)payPalPaymentViewController:(PayPalPaymentViewController *)paymentViewController willCompletePayment:(PayPalPayment *)completedPayment completionBlock:(PayPalPaymentDelegateCompletionBlock)completionBlock;
		[Export ("payPalPaymentViewController:willCompletePayment:completionBlock:")]
		void PayPalPaymentViewController (PayPalPaymentViewController paymentViewController, PayPalPayment completedPayment, PayPalPaymentDelegateCompletionBlock completionBlock);
	}

	// @interface PayPalPaymentViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface PayPalPaymentViewController
	{
		// -(instancetype)initWithPayment:(PayPalPayment *)payment configuration:(PayPalConfiguration *)configuration delegate:(id<PayPalPaymentDelegate>)payPalPaymentDelegate;
		[Export ("initWithPayment:configuration:delegate:")]
		IntPtr Constructor (PayPalPayment payment, PayPalConfiguration configuration, PayPalPaymentDelegate @payPalPaymentDelegate);

		[Wrap ("WeakPaymentDelegate")]
		PayPalPaymentDelegate PaymentDelegate { get; }

		// @property (readonly, nonatomic, weak) id<PayPalPaymentDelegate> paymentDelegate;
		[NullAllowed, Export ("paymentDelegate", ArgumentSemantic.Weak)]
		NSObject WeakPaymentDelegate { get; }

		// @property (readonly, assign, nonatomic) PayPalPaymentViewControllerState state;
		[Export ("state", ArgumentSemantic.Assign)]
		PayPalPaymentViewControllerState State { get; }
	}

	// typedef void (^PayPalProfileSharingDelegateCompletionBlock)();
	delegate void PayPalProfileSharingDelegateCompletionBlock ();

	// @protocol PayPalProfileSharingDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PayPalProfileSharingDelegate
	{
		// @required -(void)userDidCancelPayPalProfileSharingViewController:(PayPalProfileSharingViewController *)profileSharingViewController;
		[Abstract]
		[Export ("userDidCancelPayPalProfileSharingViewController:")]
		void UserDidCancelPayPalProfileSharingViewController (PayPalProfileSharingViewController profileSharingViewController);

		// @required -(void)payPalProfileSharingViewController:(PayPalProfileSharingViewController *)profileSharingViewController userDidLogInWithAuthorization:(NSDictionary *)profileSharingAuthorization;
		[Abstract]
		[Export ("payPalProfileSharingViewController:userDidLogInWithAuthorization:")]
		void PayPalProfileSharingViewController (PayPalProfileSharingViewController profileSharingViewController, NSDictionary profileSharingAuthorization);

		// @optional -(void)payPalProfileSharingViewController:(PayPalProfileSharingViewController *)profileSharingViewController userWillLogInWithAuthorization:(NSDictionary *)profileSharingAuthorization completionBlock:(PayPalProfileSharingDelegateCompletionBlock)completionBlock;
		[Export ("payPalProfileSharingViewController:userWillLogInWithAuthorization:completionBlock:")]
		void PayPalProfileSharingViewController (PayPalProfileSharingViewController profileSharingViewController, NSDictionary profileSharingAuthorization, PayPalProfileSharingDelegateCompletionBlock completionBlock);
	}

	// @interface PayPalProfileSharingViewController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface PayPalProfileSharingViewController
	{
		// -(instancetype)initWithScopeValues:(NSSet *)scopeValues configuration:(PayPalConfiguration *)configuration delegate:(id<PayPalProfileSharingDelegate>)del;
		[Export ("initWithScopeValues:configuration:delegate:")]
		IntPtr Constructor (NSSet scopeValues, PayPalConfiguration configuration, PayPalProfileSharingDelegate @del);

		[Wrap ("WeakProfileSharingDelegate")]
		PayPalProfileSharingDelegate ProfileSharingDelegate { get; }

		// @property (readonly, nonatomic, weak) id<PayPalProfileSharingDelegate> profileSharingDelegate;
		[NullAllowed, Export ("profileSharingDelegate", ArgumentSemantic.Weak)]
		NSObject WeakProfileSharingDelegate { get; }
	}

	//[Verify (ConstantsInterfaceAssociation)]
	partial interface EnvironmentConstants
	{
		// extern NSString *const PayPalEnvironmentProduction;
		[Field ("PayPalEnvironmentProduction")]
		NSString PayPalEnvironmentProduction { get; }

		// extern NSString *const PayPalEnvironmentSandbox;
		[Field ("PayPalEnvironmentSandbox")]
		NSString PayPalEnvironmentSandbox { get; }

		// extern NSString *const PayPalEnvironmentNoNetwork;
		[Field ("PayPalEnvironmentNoNetwork")]
		NSString PayPalEnvironmentNoNetwork { get; }
	}

	// @interface PayPalMobile : NSObject
	[BaseType (typeof(NSObject))]
	interface PayPalMobile
	{
		// +(void)initializeWithClientIdsForEnvironments:(NSDictionary *)clientIdsForEnvironments;
		[Static]
		[Export ("initializeWithClientIdsForEnvironments:")]
		void InitializeWithClientIdsForEnvironments (NSDictionary clientIdsForEnvironments);

		// +(void)preconnectWithEnvironment:(NSString *)environment;
		[Static]
		[Export ("preconnectWithEnvironment:")]
		void PreconnectWithEnvironment (string environment);

		// +(NSString *)clientMetadataID;
		[Static]
		[Export ("clientMetadataID")]
		//[Verify (MethodToProperty)]
		string ClientMetadataID { get; }

		// +(NSString *)applicationCorrelationIDForEnvironment:(NSString *)environment __attribute__((deprecated("Use clientMetadataID instead.")));
		[Static]
		[Export ("applicationCorrelationIDForEnvironment:")]
		string ApplicationCorrelationIDForEnvironment (string environment);

		// +(void)clearAllUserData;
		[Static]
		[Export ("clearAllUserData")]
		void ClearAllUserData ();

		// +(NSString *)libraryVersion;
		[Static]
		[Export ("libraryVersion")]
		//[Verify (MethodToProperty)]
		string LibraryVersion { get; }
	}
}

