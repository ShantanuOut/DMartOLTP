CREATE XML SCHEMA COLLECTION [Stores].[UpdPhoneXMLSchema]
	AS N'<?xml version="1.0"?>
<xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema">
  <xs:element name="PhoneUpdateXML">
    <xs:complexType>
      <xs:choice minOccurs="0" maxOccurs="6">
        <xs:element name="Phone">
          <xs:complexType>
            <xs:simpleContent>
              <xs:extension base="xs:string">
                <xs:attribute name="PhoneId" type="xs:integer" />
                <xs:attribute name="IsPrimary" type="xs:integer" />
              </xs:extension>
            </xs:simpleContent>
          </xs:complexType>
        </xs:element>
      </xs:choice>
    </xs:complexType>
  </xs:element>
</xs:schema>'