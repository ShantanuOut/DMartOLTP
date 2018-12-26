CREATE XML SCHEMA COLLECTION [Stores].[DelPhoneXMLSchema]
	AS N'<?xml version="1.0"?>
<xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <xs:element name="PhoneIdsToDelete">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="5">
        <xs:element name="PhoneId">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base="xs:string">
                <xs:attribute name="IsPrimary" type="xs:string" />
                <xs:attribute name="AlternatePrimary" type="xs:string" />
              </xs:extension>
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>'