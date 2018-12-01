CREATE XML SCHEMA COLLECTION [Stores].[PhoneXMLSchema]
	AS N'<?xml version="1.0"?>
<xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema">
	<xs:element name="PhoneNumbers">
		<xs:complexType>
			<xs:sequence>			  
				<xs:element name="Phone" minOccurs="0" maxOccurs="3">			  
					<xs:complexType>
						<xs:simpleContent>
							<xs:extension base="xs:string">
								<xs:attribute name="IsPrimary" type="xs:integer" use="required" />
							</xs:extension>
						</xs:simpleContent>
					</xs:complexType>
				</xs:element>
			</xs:sequence>			
		</xs:complexType>
	</xs:element>	
</xs:schema>
';